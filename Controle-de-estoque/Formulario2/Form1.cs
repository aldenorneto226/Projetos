using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite; // Importa a biblioteca do SQLite

namespace Formulario2
{
    public partial class Form1 : Form
    {
        // Linha de conexão que diz onde o arquivo do banco de dados será criado/salvo
        private string stringConexao = "Data Source=estoque.db;Version=3;";

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // Nossa lista que guardará os objetos do tipo "Produto" na memória
        private List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrade(); // Configura as colunas da tabela ao iniciar
            CriarBancoEDireto(); // Cria o banco e a tabela se eles não existirem
            AtualizarTabelaTela(); // Carrega os dados salvos ao abrir o programa

            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        // Método para criar as colunas da tabela (linhas e colunas reais)
        private void ConfigurarGrade()
        {
            dgvEstoque.Columns.Clear();
            dgvEstoque.Columns.Add("colId", "ID"); // Adicionamos o ID para controle interno
            dgvEstoque.Columns.Add("colNome", "Produto");
            dgvEstoque.Columns.Add("colQuantidade", "Quantidade");
            dgvEstoque.Columns.Add("colValor", "Preço Unitário");
            dgvEstoque.Columns.Add("colTotalItem", "Total do Item");

            // Ajusta as colunas para preencherem todo o espaço disponível na tela
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Impede o usuário de editar os dados clicando direto na tabela (opcional)
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.ReadOnly = true;

            // Permite selecionar a linha inteira ao clicar em qualquer célula da tabela
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string qtdTexto = txtQuantidade.Text.Trim();
            string valorTexto = txtValor.Text.Trim();

            if (string.IsNullOrEmpty(nome) || !int.TryParse(qtdTexto, out int quantidade) || !decimal.TryParse(valorTexto, out decimal valor))
            {
                MessageBox.Show("Por favor, verifique se todos os campos estão preenchidos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
            {
                conexao.Open();

                // TRUQUE INTELIGENTE: Primeiro, tentamos atualizar o produto se o nome já existir
                // Ele vai somar a quantidade existente com a nova (+ @Quantidade) e atualizar o preço
                string sqlUpdate = "UPDATE Produtos SET Quantidade = Quantidade + @Quantidade, Valor = @Valor WHERE Nome = @Nome";

                using (SQLiteCommand comandoUpdate = new SQLiteCommand(sqlUpdate, conexao))
                {
                    comandoUpdate.Parameters.AddWithValue("@Nome", nome);
                    comandoUpdate.Parameters.AddWithValue("@Quantidade", quantidade);
                    comandoUpdate.Parameters.AddWithValue("@Valor", valor);

                    // ExecuteNonQuery devolve o número de linhas que ele conseguiu alterar no banco
                    int linhasAfetadas = comandoUpdate.ExecuteNonQuery();

                    // Se linhasAfetadas for IGUAL A ZERO, significa que esse produto NÃO existia!
                    if (linhasAfetadas == 0)
                    {
                        // Como não existia, fazemos o INSERT tradicional
                        string sqlInsert = "INSERT INTO Produtos (Nome, Quantidade, Valor) VALUES (@Nome, @Quantidade, @Valor)";

                        using (SQLiteCommand comandoInsert = new SQLiteCommand(sqlInsert, conexao))
                        {
                            comandoInsert.Parameters.AddWithValue("@Nome", nome);
                            comandoInsert.Parameters.AddWithValue("@Quantidade", quantidade);
                            comandoInsert.Parameters.AddWithValue("@Valor", valor);
                            comandoInsert.ExecuteNonQuery();
                        }
                    }
                }
            }

            // Recarrega a grade e o dashboard com as novas informações agrupadas
            AtualizarTabelaTela();

            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtNome.Focus();
        }
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente apagar TODO o estoque do banco de dados?", "Confirmar Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
                {
                    conexao.Open();
                    string sql = "DELETE FROM Produtos"; // Apaga todas as linhas da tabela

                    using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                    {
                        comando.ExecuteNonQuery();
                    }
                }

                AtualizarTabelaTela();
                txtNome.Clear();
                txtQuantidade.Clear();
                txtValor.Clear();
            }
        }
        // ATUALIZADO: Agora adiciona linhas reais no DataGridView
        // Método que LISTA os dados na tela buscando direto do Banco (SELECT)
        private void AtualizarTabelaTela()
        {
            dgvEstoque.Rows.Clear();
            listaEstoque.Clear(); // CORREÇÃO: Limpa a lista antiga da memória antes de reabastecer

            decimal valorTotalAcumulado = 0;

            // Conecta ao banco para BUSCAR (SELECT)
            using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
            {
                conexao.Open();
                string sql = "SELECT Id, Nome, Quantidade, Valor FROM Produtos";

                using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                {
                    using (SQLiteDataReader leitor = comando.ExecuteReader())
                    {
                        // Enquanto houver linhas no banco de dados, o "while" continua lendo
                        while (leitor.Read())
                        {
                            int id = leitor.GetInt32(0);
                            string nome = leitor.GetString(1);
                            int quantidade = leitor.GetInt32(2);
                            decimal valor = leitor.GetDecimal(3);

                            decimal totalDoItem = quantidade * valor;
                            valorTotalAcumulado += totalDoItem;

                            // CORREÇÃO: Alimenta a listaEstoque para o Dashboard poder ler depois!
                            Produto prod = new Produto
                            {
                                Nome = nome,
                                Quantity = quantidade,
                                Valor = valor
                            };
                            listaEstoque.Add(prod);

                            // Adiciona na tabela visual
                            dgvEstoque.Rows.Add(id, nome, quantidade, valor.ToString("C"), totalDoItem.ToString("C"));
                        }
                    }
                }
            }

            lblTotalEstoque.Text = $"Valor Total do Estoque: {valorTotalAcumulado:C}";
        }

        private void lblTotalEstoque_Click(object sender, EventArgs e)
        {

        }
        //Botão para Dar Saída (Retirar Quantidade)
        private void btnSaida_Click(object sender, EventArgs e)
        {
            // 1. Verifica se o usuário selecionou uma linha na tabela
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione o produto na tabela antes de dar saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verifica se a quantidade digitada para retirar é válida
            string qtdTexto = txtQuantidade.Text.Trim();
            if (!int.TryParse(qtdTexto, out int quantidadeRetirar) || quantidadeRetirar <= 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida maior que 0 para retirar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Pega o ID e a Quantidade Atual diretamente da linha selecionada na tabela
            int idSelecionado = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["colId"].Value);
            int qtdAtual = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["colQuantidade"].Value);
            string nomeProduto = dgvEstoque.CurrentRow.Cells["colNome"].Value.ToString();

            if (qtdAtual < quantidadeRetirar)
            {
                MessageBox.Show("Estoque insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int novaQuantidade = qtdAtual - quantidadeRetirar;

            // Conecta ao banco de dados para ATUALIZAR (UPDATE)
            using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
            {
                conexao.Open();
                string sql = "UPDATE Produtos SET Quantidade = @Quantidade WHERE Id = @Id";

                using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Quantidade", novaQuantidade);
                    comando.Parameters.AddWithValue("@Id", idSelecionado);
                    comando.ExecuteNonQuery();
                }
            }

            AtualizarTabelaTela();
            txtQuantidade.Clear();
            MessageBox.Show($"Saída realizada para o produto '{nomeProduto}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Filtros de digitação (conforme configurado no passo anterior)
        // 1. Evento para o campo QUANTIDADE (Apenas números inteiros)
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla digitada NÃO for um número e NÃO for a tecla Backspace (para apagar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela o evento (bloqueia a digitação da letra)
                e.Handled = true;
            }
        }

        // 2. Evento para o campo VALOR (Aceita números e APENAS UMA vírgula)
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números e Backspace
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Permite a vírgula, mas verifica se já existe uma no campo (evita digitar "10,,50")
            if (e.KeyChar == ',' && !txtValor.Text.Contains(","))
            {
                return;
            }

            // Se chegou até aqui, bloqueia qualquer outra tecla (letras, pontos, espaços)
            e.Handled = true;
        }

        // Método que cria o arquivo .db e a tabela na primeira vez que roda
        private void CriarBancoEDireto()
        {
            using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
            {
                conexao.Open();

                // Comando SQL para criar a tabela de produtos
                string sql = @"CREATE TABLE IF NOT EXISTS Produtos (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Nome TEXT NOT NULL,
                                Quantidade INTEGER NOT NULL,
                                Valor DECIMAL(10,2) NOT NULL
                               );";

                using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        //ADD O MENU DASHBOARD
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Executa os cálculos matemáticos atualizados antes de mostrar a tela
            AtualizarDashboard();

            // 2. Mostra o painel na tela
            pnlDashboard.Visible = true;
            pnlDashboard.BringToFront();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fecha todas as telas e encerra a aplicação
            Application.Exit();
        }
        // Clique no menu "Ver Estoque" (Para Voltar)
        private void verEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Apenas esconde o painel do dashboard. 
            // Como os controles de estoque estão "atrás" dele, eles reaparecem na hora!
            pnlDashboard.Visible = false;
        }

        // Novo método para calcular os indicadores do Dashboard
        private void AtualizarDashboard()
        {
            // Indicador 1: A quantidade de produtos cadastrados é o próprio tamanho da lista
            int totalProdutosDiferentes = listaEstoque.Count;

            int totalItensAcumulados = 0;
            decimal valorFinanceiroTotal = 0;

            // Percorre a lista somando a quantidade física e o valor financeiro total
            foreach (Produto prod in listaEstoque)
            {
                totalItensAcumulados += prod.Quantity;
                valorFinanceiroTotal += (prod.Quantity * prod.Valor);
            }

            // Atualiza os Labels do Dashboard com os valores calculados
            lblDashProdutos.Text = $"Produtos Cadastrados: {totalProdutosDiferentes}";
            lblDashItens.Text = $"Total de Itens no Estoque: {totalItensAcumulados} un";
            lblDashValor.Text = $"Valor Total Guardado: {valorFinanceiroTotal:C}";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1. Verifica se o usuário selecionou uma linha na tabela
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um produto na tabela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Captura o ID e o Nome diretamente da linha selecionada
            int idSelecionado = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["colId"].Value);
            string nomeProduto = dgvEstoque.CurrentRow.Cells["colNome"].Value.ToString();

            // 3. Pede uma confirmação para evitar cliques acidentais
            DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o produto '{nomeProduto}' definitivamente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 4. Conecta ao banco e deleta APENAS o ID selecionado
                using (SQLiteConnection conexao = new SQLiteConnection(stringConexao))
                {
                    conexao.Open();
                    string sql = "DELETE FROM Produtos WHERE Id = @Id";

                    using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@Id", idSelecionado);
                        comando.ExecuteNonQuery();
                    }
                }

                // 5. Atualiza a tela (isso também atualiza o Dashboard automaticamente)
                AtualizarTabelaTela();
                MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // A classe Produto voltou a ser simples, pois a tabela cuida da formatação visual
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantity { get; set; } // Alterado para mapear corretamente a propriedade de quantidade
        public decimal Valor { get; set; }
    }
}
