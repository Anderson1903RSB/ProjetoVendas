namespace ProjetoVenda.formulario
{
    partial class frmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilUsuario));
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCep = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtUsuario = new TextBox();
            btnAtualizar = new Button();
            pctBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctBox).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(369, 36);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(388, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(368, 86);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(226, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(34, 157);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(331, 23);
            txtCep.TabIndex = 2;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(29, 199);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(335, 23);
            txtRua.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(385, 199);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(99, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(31, 240);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(289, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 329);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(208, 23);
            txtUsuario.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(34, 371);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(156, 43);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // pctBox
            // 
            pctBox.Image = (Image)resources.GetObject("pctBox.Image");
            pctBox.Location = new Point(29, 7);
            pctBox.Name = "pctBox";
            pctBox.Size = new Size(195, 142);
            pctBox.SizeMode = PictureBoxSizeMode.Zoom;
            pctBox.TabIndex = 8;
            pctBox.TabStop = false;
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(pctBox);
            Controls.Add(btnAtualizar);
            Controls.Add(txtUsuario);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtCep);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "frmPerfilUsuario";
            Text = "Perfil Usuario";
            Load += frmPerfilUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pctBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCep;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtUsuario;
        private Button btnAtualizar;
        private PictureBox pctBox;
    }
}