namespace ProjetoVenda.formulario
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvFuncionario = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtComplemento = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            panel2 = new Panel();
            Perfil = new Label();
            cbxAdm = new ComboBox();
            label2 = new Label();
            txtSenha1 = new TextBox();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvFuncionario, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(678, 692);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Dock = DockStyle.Fill;
            dgvFuncionario.Location = new Point(3, 403);
            dgvFuncionario.MultiSelect = false;
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.ReadOnly = true;
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.Size = new Size(672, 286);
            dgvFuncionario.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 394);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtComplemento);
            panel3.Controls.Add(txtCep);
            panel3.Controls.Add(txtNumero);
            panel3.Controls.Add(txtRua);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(txtNome);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(672, 204);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perfil__1_;
            pictureBox1.Location = new Point(563, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 124);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 25;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 24;
            label3.Text = "Nome Funcionário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 124);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 20;
            label7.Text = "CEP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 65);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 21;
            label6.Text = "Complemento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 65);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 22;
            label5.Text = "Numero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 23;
            label1.Text = "Endereço";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(361, 83);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(167, 23);
            txtComplemento.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(171, 142);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(144, 23);
            txtCep.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(264, 83);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(77, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(6, 83);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(228, 23);
            txtRua.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 142);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "(XX) XXXX-XXXX";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(498, 23);
            txtNome.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Perfil);
            panel2.Controls.Add(cbxAdm);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSenha1);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtUsuario);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 192);
            panel2.TabIndex = 0;
            // 
            // Perfil
            // 
            Perfil.AutoSize = true;
            Perfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Perfil.Location = new Point(18, 149);
            Perfil.Name = "Perfil";
            Perfil.Size = new Size(37, 15);
            Perfil.TabIndex = 24;
            Perfil.Text = "Perfil";
            // 
            // cbxAdm
            // 
            cbxAdm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAdm.FormattingEnabled = true;
            cbxAdm.Items.AddRange(new object[] { "Funcionario", "Administrador" });
            cbxAdm.Location = new Point(18, 167);
            cbxAdm.Name = "cbxAdm";
            cbxAdm.Size = new Size(116, 23);
            cbxAdm.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 10);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 22;
            label2.Text = "Login";
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(18, 114);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar Senha";
            txtSenha1.Size = new Size(160, 23);
            txtSenha1.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Control;
            btnCadastrar.FlatAppearance.BorderSize = 2;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(492, 52);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(171, 85);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.TabStop = false;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += Cadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(18, 72);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(160, 23);
            txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(18, 28);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 7;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(678, 692);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            Load += frmCadastroFuncionario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txtComplemento;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Panel panel2;
        private DataGridView dgvFuncionario;
        private Label Perfil;
        private ComboBox cbxAdm;
        private Label label2;
        private TextBox txtSenha1;
        private Button btnCadastrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
    }
}