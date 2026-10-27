using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoVenda.view
{
    public partial class frmCadastroProduto : Form
    {
        private ProductController controller;
        private Product? produtoSelecionado;
        private int totalDePaginas = 5;
        private int paginaAtual = 1;
        private int totalPorPagina = 5;

        public frmCadastroProduto()
        {
            InitializeComponent();
            controller = new ProductController();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtMarca.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Value = 0;
        }



        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);



            Product product = new Product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };

            //Enviar os dados para a controller 

            bool resp = controller.createProduct(product);

            if (resp)
            {
                MessageBox.Show("Produto cadastrado com sucesso", "Cadastro Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                carregarProdutos();

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Produto", "Cadastro Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            //FINALIZAR LISTAR OS PRODUTOS
            carregarProdutos();
            //int paginas = controller.quantidadePaginas(5);
            //lblPaginas.Text = $"1 de {paginas}";
        }
        private void carregarProdutos()
        {
            List<Product> list = controller.listarPorPagina(totalPorPagina, paginaAtual);
            this.dgvProdutos.DataSource = list;
            this.dgvProdutos.Columns["cod_funcionario"].Visible = false;
            
            totalDePaginas = controller.quantidadePaginas(totalPorPagina);
            if (paginaAtual > totalDePaginas)
            {
                paginaAtual = totalDePaginas;
            }
            atualizarLblPagina();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //evento de atualizar
            produtoSelecionado.nome = this.txtNome.Text;
            produtoSelecionado.marca = this.txtMarca.Text;
            produtoSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            produtoSelecionado.quantidade = (int)this.txtQuantidade.Value;
            bool resp = controller.atualizar(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show("Produto Atualizado com sucesso", "Atualização do Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarProdutos();
                limparCampos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o produto", "Erro na atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow linha = this.dgvProdutos.Rows[e.RowIndex];
            Product? produto = linha.DataBoundItem as Product;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnAtualizar.Enabled = true;
            this.btnExcluir.Enabled = true;

            //MessageBox.Show($"{produto.nome}");
            // return;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resp = controller.excluir(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show("Produto excluido com sucesso", "Exclusão do Produto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarProdutos();
                limparCampos();
                this.btnAtualizar.Enabled = false;
                this.btnExcluir.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show("Erro ao excluir o produto!!", "Erro exclusão",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // manipular as paginas
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                atualizarLblPagina();
                carregarProdutos();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalDePaginas)
            {
                paginaAtual++;
                atualizarLblPagina();
                carregarProdutos();
            }
        }
        private void atualizarLblPagina()
            {
                this.lblPaginas.Text = $"Pagina {paginaAtual} de {totalDePaginas}";
            }


        
    }
}
