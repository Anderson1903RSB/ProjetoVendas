namespace ProjetoVenda.formulario
{
    partial class frmCadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxProdutos = new ComboBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            numQuantidade = new NumericUpDown();
            btnAdionar = new Button();
            dgvCarrinho = new DataGridView();
            btnCadastrar = new Button();
            lblTotalVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(12, 67);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(556, 23);
            cbxProdutos.TabIndex = 0;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(18, 128);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(119, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitário  XX,XX";
            lblPreco.Click += lblPreco_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(17, 169);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade Disponível X";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(483, 120);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(85, 23);
            numQuantidade.TabIndex = 3;
            // 
            // btnAdionar
            // 
            btnAdionar.BackColor = Color.LawnGreen;
            btnAdionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdionar.Location = new Point(483, 157);
            btnAdionar.Name = "btnAdionar";
            btnAdionar.Size = new Size(85, 38);
            btnAdionar.TabIndex = 4;
            btnAdionar.Text = "Add Venda";
            btnAdionar.UseVisualStyleBackColor = false;
            btnAdionar.Click += btnAdionar_Click;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(18, 234);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(760, 334);
            dgvCarrinho.TabIndex = 5;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.System;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(315, 677);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(144, 36);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTotalVenda.Location = new Point(18, 578);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(760, 26);
            lblTotalVenda.TabIndex = 7;
            lblTotalVenda.Text = "Total da Venda R$ XX,XX";
            lblTotalVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 734);
            Controls.Add(lblTotalVenda);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvCarrinho);
            Controls.Add(btnAdionar);
            Controls.Add(numQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProdutos);
            Name = "frmCadastroVenda";
            Text = "Cadastro de Venda";
            Load += frmCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxProdutos;
        private Label lblPreco;
        private Label lblQuantidade;
        private NumericUpDown numQuantidade;
        private Button btnAdionar;
        private DataGridView dgvCarrinho;
        private Button btnCadastrar;
        private Label lblTotalVenda;
    }
}