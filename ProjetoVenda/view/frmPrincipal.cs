using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exibirFormulario(Form formulario)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            painelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }
        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            exibirFormulario(frm);
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);
        }

        private void btnCadProduto_Click_1(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);
            //frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //evento para sair
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }
    }
}
