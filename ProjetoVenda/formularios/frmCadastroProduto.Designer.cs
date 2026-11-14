namespace ProjetoVenda.formulario
{
    partial class frmCadastroProduto
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
            txtQuantidade = new NumericUpDown();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dgvProdutos = new DataGridView();
            label5 = new Label();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            cbxQuantidadeItens = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(360, 162);
            txtQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(593, 18);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(130, 57);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Produto";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += Cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(360, 137);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 5;
            label1.Text = "Quantidade";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(69, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 6;
            label2.Text = "Valor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(69, 99);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Produto";
            txtNome.Size = new Size(198, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(360, 99);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(152, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(69, 161);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 00000,00";
            txtPreco.Size = new Size(179, 23);
            txtPreco.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(69, 75);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 7;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(360, 75);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "Marca";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = SystemColors.Info;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(3, 242);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(743, 283);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(171, 9);
            label5.Name = "label5";
            label5.Size = new Size(356, 39);
            label5.TabIndex = 10;
            label5.Text = "CADASTRO DE PRODUTOS";
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 12F);
            btnExcluir.Location = new Point(593, 179);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(130, 57);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir Produto";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(593, 99);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(130, 57);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar Produto";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 12F);
            btnAnterior.Location = new Point(3, 580);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(101, 52);
            btnAnterior.TabIndex = 11;
            btnAnterior.Text = "<< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Font = new Font("Segoe UI", 12F);
            btnProximo.Location = new Point(631, 576);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(103, 52);
            btnProximo.TabIndex = 12;
            btnProximo.Text = "Proximo >>";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaginas.Location = new Point(110, 595);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(515, 23);
            lblPaginas.TabIndex = 13;
            lblPaginas.Text = "<Pagina 1 de 5>";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            lblPaginas.Click += lblPaginas_Click;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "7", "13", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(69, 213);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(114, 23);
            cbxQuantidadeItens.TabIndex = 14;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(69, 189);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 15;
            label6.Text = "Qtde itens";
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(746, 648);
            Controls.Add(label6);
            Controls.Add(cbxQuantidadeItens);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(label5);
            Controls.Add(dgvProdutos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtQuantidade);
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown txtQuantidade;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private Label label3;
        private Label label4;
        private DataGridView dgvProdutos;
        private Label label5;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
        private ComboBox cbxQuantidadeItens;
        private Label label6;
    }
}