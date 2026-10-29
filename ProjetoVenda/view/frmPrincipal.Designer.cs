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
            panel2 = new Panel();
            painelPrincipal = new Panel();
            btnSair = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnCadFuncionario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCadProduto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 631);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 109);
            panel2.TabIndex = 3;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(230, 109);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(707, 522);
            painelPrincipal.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(37, 564);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(147, 47);
            btnSair.TabIndex = 2;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(937, 631);
            Controls.Add(painelPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}