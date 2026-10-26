namespace ProjetoVenda.view
{
    partial class frmLogin
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(75, 85);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(75, 144);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(75, 214);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 46);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(75, 21);
            label1.Name = "label1";
            label1.Size = new Size(101, 39);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(263, 300);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label label1;
    }
}