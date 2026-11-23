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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCarrinho = new DataGridView();
            panel1 = new Panel();
            btnAdionar = new Button();
            numQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            lblPreco = new Label();
            cbxProdutos = new ComboBox();
            panel2 = new Panel();
            lblTotalVenda = new Label();
            btnCadastrar = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvCarrinho, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(707, 721);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.Anchor = AnchorStyles.Top;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(3, 183);
            dgvCarrinho.MultiSelect = false;
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(701, 385);
            dgvCarrinho.TabIndex = 6;
            dgvCarrinho.CellDoubleClick += dgvCarrinho_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(btnAdionar);
            panel1.Controls.Add(numQuantidade);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(cbxProdutos);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 174);
            panel1.TabIndex = 0;
            // 
            // btnAdionar
            // 
            btnAdionar.BackColor = Color.LawnGreen;
            btnAdionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdionar.Location = new Point(543, 113);
            btnAdionar.Name = "btnAdionar";
            btnAdionar.Size = new Size(85, 38);
            btnAdionar.TabIndex = 9;
            btnAdionar.Text = "Add Venda";
            btnAdionar.UseVisualStyleBackColor = false;
            btnAdionar.Click += btnAdionar_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(543, 76);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(85, 23);
            numQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(77, 125);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade Disponível X";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(78, 84);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(119, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço Unitário  XX,XX";
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(72, 23);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(556, 23);
            cbxProdutos.TabIndex = 5;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalVenda);
            panel2.Controls.Add(btnCadastrar);
            panel2.Location = new Point(3, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 144);
            panel2.TabIndex = 7;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalVenda.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTotalVenda.Location = new Point(0, 5);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(698, 26);
            lblTotalVenda.TabIndex = 9;
            lblTotalVenda.Text = "Total da Venda R$ XX,XX";
            lblTotalVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.FlatStyle = FlatStyle.System;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(612, 95);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 36);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(709, 734);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCadastroVenda";
            Text = "Cadastro de Venda";
            Load += frmCadastroVenda_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnAdionar;
        private NumericUpDown numQuantidade;
        private Label lblQuantidade;
        private Label lblPreco;
        private ComboBox cbxProdutos;
        private DataGridView dgvCarrinho;
        private Panel panel2;
        private Label lblTotalVenda;
        private Button btnCadastrar;
    }
}