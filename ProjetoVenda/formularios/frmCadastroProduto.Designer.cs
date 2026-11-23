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
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProdutos = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            cbxQuantidadeItens = new ComboBox();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPreco = new TextBox();
            txtMarca = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            txtQuantidade = new NumericUpDown();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 12F);
            btnAnterior.Location = new Point(11, 26);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(105, 55);
            btnAnterior.TabIndex = 11;
            btnAnterior.Text = "<< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProximo.Font = new Font("Segoe UI", 12F);
            btnProximo.Location = new Point(876, 26);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(105, 55);
            btnProximo.TabIndex = 12;
            btnProximo.Text = "Proximo >>";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPaginas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaginas.Location = new Point(250, 42);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(469, 23);
            lblPaginas.TabIndex = 13;
            lblPaginas.Text = "<Pagina 1 de 5>";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            lblPaginas.Click += lblPaginas_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvProdutos, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(995, 697);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.Silver;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(3, 183);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(989, 421);
            dgvProdutos.TabIndex = 10;
            dgvProdutos.CellContentDoubleClick += dgvProdutos_CellDoubleClick;
            dgvProdutos.DoubleClick += cbxQuantidadeItens_SelectedIndexCh;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbxQuantidadeItens);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtQuantidade);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 174);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(135, 111);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 28;
            label6.Text = "Qtde itens";
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "7", "13", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(135, 137);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(114, 23);
            cbxQuantidadeItens.TabIndex = 27;
            cbxQuantidadeItens.Click += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Tomato;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(525, 129);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(145, 33);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir Produto";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = SystemColors.ButtonFace;
            btnAtualizar.Enabled = false;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.Bisque;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(709, 129);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(145, 33);
            btnAtualizar.TabIndex = 21;
            btnAtualizar.Text = "Atualizar Produto";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(525, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 26;
            label4.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(135, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 25;
            label3.Text = "Produto";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(135, 85);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(179, 23);
            txtPreco.TabIndex = 18;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(525, 24);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(152, 23);
            txtMarca.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(135, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(368, 23);
            txtNome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(134, 61);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 24;
            label2.Text = "Valor R$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(525, 62);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 22;
            label1.Text = "Quantidade";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.WhiteSmoke;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(736, 24);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 67);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar Produto";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += Cadastrar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(525, 86);
            txtQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProximo);
            panel2.Controls.Add(lblPaginas);
            panel2.Controls.Add(btnAnterior);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 610);
            panel2.Name = "panel2";
            panel2.Size = new Size(989, 84);
            panel2.TabIndex = 1;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(995, 697);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += frmCadastroProduto_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label6;
        private ComboBox cbxQuantidadeItens;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Label label4;
        private Label label3;
        private TextBox txtPreco;
        private TextBox txtMarca;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btnCadastrar;
        private NumericUpDown txtQuantidade;
        private Panel panel2;
        private DataGridView dgvProdutos;
    }
}