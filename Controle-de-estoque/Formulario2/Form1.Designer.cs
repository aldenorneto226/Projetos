namespace Formulario2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.lblTotalEstoque = new System.Windows.Forms.Label();
            this.btnSaida = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblDashValor = new System.Windows.Forms.Label();
            this.lblDashItens = new System.Windows.Forms.Label();
            this.lblDashProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(167, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Location = new System.Drawing.Point(340, 98);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(438, 137);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 24);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Adicionar ao Estoque";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(294, 390);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Zerar Estoque";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(459, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor R$";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(40, 179);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.RowTemplate.Height = 24;
            this.dgvEstoque.Size = new System.Drawing.Size(518, 170);
            this.dgvEstoque.TabIndex = 6;
            // 
            // lblTotalEstoque
            // 
            this.lblTotalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEstoque.AutoSize = true;
            this.lblTotalEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEstoque.Location = new System.Drawing.Point(304, 360);
            this.lblTotalEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEstoque.Name = "lblTotalEstoque";
            this.lblTotalEstoque.Size = new System.Drawing.Size(242, 17);
            this.lblTotalEstoque.TabIndex = 10;
            this.lblTotalEstoque.Text = "Valor Total do Estoque: R$ 0,00";
            this.lblTotalEstoque.Click += new System.EventHandler(this.lblTotalEstoque_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaida.BackColor = System.Drawing.Color.DarkRed;
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaida.Location = new System.Drawing.Point(346, 137);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(75, 24);
            this.btnSaida.TabIndex = 99;
            this.btnSaida.Text = "Dar Saída";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEstoqueToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultaToolStripMenuItem.Text = "Consultas";
            // 
            // verEstoqueToolStripMenuItem
            // 
            this.verEstoqueToolStripMenuItem.Name = "verEstoqueToolStripMenuItem";
            this.verEstoqueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verEstoqueToolStripMenuItem.Text = "Ver Estoque";
            this.verEstoqueToolStripMenuItem.Click += new System.EventHandler(this.verEstoqueToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dashboardToolStripMenuItem.Text = "Ver Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDashboard.Controls.Add(this.lblDashValor);
            this.pnlDashboard.Controls.Add(this.lblDashItens);
            this.pnlDashboard.Controls.Add(this.lblDashProdutos);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(581, 443);
            this.pnlDashboard.TabIndex = 101;
            this.pnlDashboard.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(483, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblDashValor
            // 
            this.lblDashValor.AutoSize = true;
            this.lblDashValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashValor.Location = new System.Drawing.Point(43, 209);
            this.lblDashValor.Name = "lblDashValor";
            this.lblDashValor.Size = new System.Drawing.Size(254, 20);
            this.lblDashValor.TabIndex = 2;
            this.lblDashValor.Text = "Valor Total Guardado: R$ 0,00";
            // 
            // lblDashItens
            // 
            this.lblDashItens.AutoSize = true;
            this.lblDashItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashItens.Location = new System.Drawing.Point(43, 155);
            this.lblDashItens.Name = "lblDashItens";
            this.lblDashItens.Size = new System.Drawing.Size(237, 20);
            this.lblDashItens.TabIndex = 1;
            this.lblDashItens.Text = "Total de Itens no Estoque: 0";
            // 
            // lblDashProdutos
            // 
            this.lblDashProdutos.AutoSize = true;
            this.lblDashProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashProdutos.Location = new System.Drawing.Point(43, 97);
            this.lblDashProdutos.Name = "lblDashProdutos";
            this.lblDashProdutos.Size = new System.Drawing.Size(208, 20);
            this.lblDashProdutos.TabIndex = 0;
            this.lblDashProdutos.Text = "Produtos Cadastrados: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.lblTotalEstoque);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label lblTotalEstoque;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.ToolStripMenuItem verEstoqueToolStripMenuItem;
        private System.Windows.Forms.Label lblDashProdutos;
        private System.Windows.Forms.Label lblDashValor;
        private System.Windows.Forms.Label lblDashItens;
        private System.Windows.Forms.Button btnExcluir;
    }
}

