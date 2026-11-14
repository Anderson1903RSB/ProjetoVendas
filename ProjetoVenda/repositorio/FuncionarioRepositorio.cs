using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repositorio
{
    internal class FuncionarioRepositorio
    {
        private Funcionario mapear(MySqlDataReader reader)
        {
            return new Funcionario
            {
                cod_funcionario = reader.GetInt32("cod_funcionario"),
                nome = reader.GetString("nome"),
                usuario = reader.GetString("usuario"),
                senha = reader.GetString("senha"),
                telefone = reader.GetString("telefone"),
                rua = (reader.IsDBNull(reader.GetOrdinal("rua"))) ? null : reader.GetString("rua"),
                numero = reader.GetString("numero"),
                complemento = (reader.IsDBNull(reader.GetOrdinal("complemento"))) ? null : reader.GetString("complemento"),
                cep = reader.GetString("cep"),
                adm = reader.GetBoolean("adm")
            };

            //ternario = pode_beber = (condicao) ? true : false;
        }
        public Funcionario? pegarPorNomeDeUsuario(string nomeDeUsuario)
        {
            using MySqlConnection connector = bancodedados.conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@username", nomeDeUsuario);
            using var cursor = cmd.ExecuteReader();
            if (cursor.Read())
            {
                return mapear(cursor);
            }
            return null;
        }

        public List<Funcionario> getAll()

        {

            using MySqlConnection connector = bancodedados.conexao();

            string sql = "SELECT * FROM funcionario";

            using MySqlCommand cmd = new MySqlCommand(sql, connector);

            using var reader = cmd.ExecuteReader();


            List<Funcionario> list = new List<Funcionario>();

            while (reader.Read())

            {

                list.Add(mapear(reader));

            }

            return list;

        }
        public List<Funcionario> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection connector = bancodedados.conexao();
            string sql = "SELECT * FROM funcionario LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();


            List<Funcionario> list = new List<Funcionario>();

            while (reader.Read())

            {

                list.Add(mapear(reader));

            }

            return list;
        }

        public int criarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection conector = bancodedados.conexao();
            string sql = @"INSERT INTO funcionario(nome, usuario, senha, telefone, rua, numero, complemento, cep, adm) VALUES (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;

        }
        public List<Funcionario> listarFuncionarios()
        {
            using MySqlConnection connector = bancodedados.conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var cursor = cmd.ExecuteReader();

            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            while (cursor.Read())
            {
                listaFuncionarios.Add(mapear(cursor));
            }
            return listaFuncionarios;
        }
    }
}
