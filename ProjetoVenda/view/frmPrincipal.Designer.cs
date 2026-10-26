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
            SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Location = new Point(97, 116);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(157, 85);
            btnCadFuncionario.TabIndex = 0;
            btnCadFuncionario.Text = "Cadastro Funcionario";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(97, 242);
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
            label1.Font = new Font("Swis721 WGL4 BT", 20F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(60, 44);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(374, 450);
            Controls.Add(label1);
            Controls.Add(btnCadProduto);
            Controls.Add(btnCadFuncionario);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadFuncionario;
        private Button btnCadProduto;
        private Label label1;
    }
}