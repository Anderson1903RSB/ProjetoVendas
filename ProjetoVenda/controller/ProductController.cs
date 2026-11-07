using ProjetoVenda.repository;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class ProductController
    {
        private ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }

        public bool createProduct(Product produto)
        {
            int cod_funcionario = Session.userAuth.cod_funcionario;
            produto.cod_funcionario = cod_funcionario;
            produto.validar();
            // chamar a repository E FAZER O CADASTRO
            repository.createProduct(produto);

            return true;
        }

        public List<Product> ListarProdutos()
        {
            return repository.getAll();
        }

        public List<Product> listarPorPagina(int qtd, int pagina)

        {
            return repository.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItens)
        {
            int totalProdutos = repository.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)totalProdutos / quantidadeItens);
        }

        public bool atualizar(Product product) 
        {
            return repository.atualizar(product);
        }

        public bool excluir(Product product)
        {
            return repository.excluir(product.cod_produto);
        }
    }
}

