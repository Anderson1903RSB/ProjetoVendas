using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmCadastroFuncionario : Form
    {
        private EmployeeController controller;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller=new EmployeeController();
        }
        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtCep.Clear();
            this.txtComplemento.Clear();

            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtSenha1.Clear();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string senha1 = this.txtSenha1.Text;

            bool adm = (this.cbxAdm.SelectedIndex == 0)? false: true;
            //bool adm = this.cbxAdm.SelectedIndex == 1;

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senhas não conferem",
                    "Senhas incorretas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //chamar o controlador do usuario para cadastro
            Employee funcionario = new Employee
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm

            };
            EmployeeController controller = new EmployeeController();
            bool resp = controller.createEmployee(funcionario);

            if (resp)
            {
                MessageBox.Show("Funcionario cadastrado com sucesso", "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionario", "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            
            carregarFuncionario();
            this.cbxAdm.SelectedIndex = 0;
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow linha = this.dgvFuncionario.Rows[e.RowIndex];
            Employee? funcionario = linha.DataBoundItem as Employee;

            this.txtNome.Text = funcionario.nome;
            this.txtTelefone.Text = funcionario.telefone;
            this.txtRua.Text = funcionario.rua;
            this.txtComplemento.Text = funcionario.complemento;
            this.txtCep.Text = funcionario.cep;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void carregarFuncionario()
        {
            List<Employee> lista = controller.listarFuncionarios();
            dgvFuncionario.DataSource = lista;
            dgvFuncionario.Columns["senha"].Visible = false;
        }
    }

}
