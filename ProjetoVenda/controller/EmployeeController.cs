using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;
using ProjetoVenda.repository;


namespace ProjetoVenda.controller
{
    internal class EmployeeController
    {
        private EmployeeRepository repository;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        public  bool login(string username, string password)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }

            bool validatePassword;
            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            } catch (Exception ex)
            {
                validatePassword = false;
            }

            if ( !validatePassword )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!
            Session.userAuth = resp;
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


        public  bool createEmployee (Employee funcionario)
        {

            //fazer verificação se o usuario não existe
            //solicitar ao repository se o usuario existe
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(funcionario.usuario);
            if (resp != null) 
            {
                return false;
            }
            string hash = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = hash;
            
            repository.createEmployee(funcionario);

            return true;

        }
        public void deslogar()
        {
            Session.userAuth = null;
        }

        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }

        public List<Employee> listarFuncionarios()

        {

            return repository.listarFuncionarios();

        }

        public bool usuarioAdministrador()
        {
            if ( Session.userAuth == null)
            {
                return false;
            }
            return Session.userAuth.adm;
        }

    }


}
