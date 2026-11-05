namespace ProjetoVenda.view
{
    partial class frmCadastroFuncionario
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
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            btnCadastrar = new Button();
            txtSenha1 = new TextBox();
            txtComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvFuncionario = new DataGridView();
            cbxAdm = new ComboBox();
            Perfil = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 81);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(498, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(58, 189);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(58, 233);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(160, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(574, 81);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(58, 129);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(228, 23);
            txtRua.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(292, 129);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(77, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(574, 129);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(144, 23);
            txtCep.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(503, 233);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(171, 85);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.TabStop = false;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += Cadastrar_Click;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(58, 275);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar Senha";
            txtSenha1.Size = new Size(160, 23);
            txtSenha1.TabIndex = 8;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(389, 129);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(167, 23);
            txtComplemento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 111);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "Endereço";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 171);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 63);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 12;
            label3.Text = "Nome Funcionário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 63);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 13;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(166, 9);
            label5.Name = "label5";
            label5.Size = new Size(399, 39);
            label5.TabIndex = 14;
            label5.Text = "CADASTRO DE FUNCIONARIO";
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(12, 352);
            dgvFuncionario.MultiSelect = false;
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.Size = new Size(706, 328);
            dgvFuncionario.TabIndex = 15;
            dgvFuncionario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionario", "Administrador" });
            cbxAdm.Location = new Point(67, 323);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(116, 23);
            cbxAdm.TabIndex = 16;
            // 
            // Perfil
            // 
            Perfil.AutoSize = true;
            Perfil.Location = new Point(67, 305);
            Perfil.Name = "Perfil";
            Perfil.Size = new Size(34, 15);
            Perfil.TabIndex = 17;
            Perfil.Text = "Perfil";
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 692);
            Controls.Add(Perfil);
            Controls.Add(cbxAdm);
            Controls.Add(dgvFuncionario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtComplemento);
            Controls.Add(txtSenha1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            Load += frmCadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtCep;
        private Button btnCadastrar;
        private TextBox txtSenha1;
        private TextBox txtComplemento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvFuncionario;
        private ComboBox cbxAdm;
        private Label Perfil;
    }
}