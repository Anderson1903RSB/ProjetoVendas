using ProjetoVenda.controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.formulario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FuncionarioControle controller = new FuncionarioControle();
            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;

            if (controller.autenticar(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuário ou senha incorretos",
                    "Erro de Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                //this.txtUsuario.Text = "";this.txtSenha.Text = "";
            }

            /*    if (Session.login(usuario, senha))    {        this.DialogResult = DialogResult.OK;        this.Close();    } else    {        MessageBox.Show(            "Usuário ou senha incorretos",            "Erro de Login",            MessageBoxButtons.OK,            MessageBoxIcon.Error            );        //this.txtUsuario.Text = "";        this.txtSenha.Text = "";    }    */
        }

    }
}
