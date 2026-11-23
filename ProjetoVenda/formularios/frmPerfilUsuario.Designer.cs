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
            Endereco = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pctBox).BeginInit();
            Endereco.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(0, 45);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(388, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(0, 111);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(226, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(6, 41);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(127, 23);
            txtCep.TabIndex = 2;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(7, 99);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(335, 23);
            txtRua.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(404, 99);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(99, 23);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(7, 156);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(289, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(3, 33);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 23);
            txtUsuario.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.LightGray;
            btnAtualizar.FlatAppearance.BorderSize = 2;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Location = new Point(586, 380);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(156, 43);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
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
            // Endereco
            // 
            Endereco.Controls.Add(label3);
            Endereco.Controls.Add(label4);
            Endereco.Controls.Add(label2);
            Endereco.Controls.Add(label1);
            Endereco.Controls.Add(txtCep);
            Endereco.Controls.Add(txtRua);
            Endereco.Controls.Add(txtComplemento);
            Endereco.Controls.Add(txtNumero);
            Endereco.Location = new Point(29, 155);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(759, 185);
            Endereco.TabIndex = 9;
            Endereco.TabStop = false;
            Endereco.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Complemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 81);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "Rua";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(245, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 140);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funcionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 93);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 27);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Location = new Point(32, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 84);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario";
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Endereco);
            Controls.Add(pctBox);
            Controls.Add(btnAtualizar);
            Name = "frmPerfilUsuario";
            Text = "Perfil Usuario";
            Load += frmPerfilUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pctBox).EndInit();
            Endereco.ResumeLayout(false);
            Endereco.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox Endereco;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
    }
}