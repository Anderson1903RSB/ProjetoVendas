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

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.ShowDialog();
        }

        private void btnCadProduto_Click_1(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.ShowDialog();
        }
    }
}
