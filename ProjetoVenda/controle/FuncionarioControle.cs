using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;


namespace ProjetoVenda.controle
{
    internal class FuncionarioControle
    {
        private FuncionarioRepositorio repositorio;
        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }
        public  bool autenticar(string nomeDeUsuario, string senha)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? funcionario = repositorio.pegarPorNomeDeUsuario(nomeDeUsuario);
            if (funcionario == null)
            {
                return false;
            }

            bool validarSenha;
            try
            {
                validarSenha = BCrypt.Net.BCrypt.Verify(senha, funcionario.senha);
            } catch (Exception ex)
            {
                validarSenha = false;
            }

            if ( !validarSenha )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!
            Sessao.usuarioAutenticado = funcionario;
            return true;
            //if (username == "admin" && password == "admin")
            //{
            //    Session.userAuth = new Employee
            //    {
            //        nome = "Administrador"
            //    };
            //    return true;
            //}
            
        }


        public  bool criarFuncionario (Funcionario funcionario)
        {

            //fazer verificação se o usuario não existe
            //solicitar ao repository se o usuario existe
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resposta = repositorio.pegarPorNomeDeUsuario(funcionario.usuario);
            if (resposta != null) 
            {
                return false;
            }
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhaCriptografada;
            
            repositorio.criarFuncionario(funcionario);

            return true;

        }
        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }

        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }

        public List<Funcionario> listarFuncionarios()

        {

            return repositorio.listarFuncionarios();

        }

        public bool usuarioAdministrador()
        {
            if ( Sessao.usuarioAutenticado == null)
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }

    }


}
