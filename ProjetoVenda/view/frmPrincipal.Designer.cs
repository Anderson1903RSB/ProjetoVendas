namespace ProjetoVenda.view
{
    partial class frmPrincipal
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
            btnCadFuncionario = new Button();
            btnCadProduto = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCadVenda = new Button();
            btnPerfil = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            lblTitulo = new Label();
            painelPrincipal = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadFuncionario.Location = new Point(37, 133);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(157, 85);
            btnCadFuncionario.TabIndex = 0;
            btnCadFuncionario.Text = "Cadastro Funcionario";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadProduto.Location = new Point(37, 259);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(157, 75);
            btnCadProduto.TabIndex = 1;
            btnCadProduto.Text = "Cadastro Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Swis721 WGL4 BT", 16F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCadVenda);
            panel1.Controls.Add(btnPerfil);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnCadFuncionario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCadProduto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 872);
            panel1.TabIndex = 2;
            // 
            // btnCadVenda
            // 
            btnCadVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadVenda.Location = new Point(39, 352);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(151, 73);
            btnCadVenda.TabIndex = 4;
            btnCadVenda.Text = "Cadastrar Venda";
            btnCadVenda.UseVisualStyleBackColor = true;
            btnCadVenda.Click += btnCadVenda_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPerfil.Location = new Point(37, 592);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(140, 46);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.IndianRed;
            btnSair.Location = new Point(37, 649);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(140, 47);
            btnSair.TabIndex = 2;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 109);
            panel2.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.AppWorkspace;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.IndianRed;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(816, 109);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo da Tela";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(230, 109);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(816, 763);
            painelPrincipal.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1046, 872);
            Controls.Add(painelPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadFuncionario;
        private Button btnCadProduto;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnPerfil;
        private Button btnCadVenda;
        private Label lblTitulo;
    }
}