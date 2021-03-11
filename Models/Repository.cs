using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class Repository
    {
        /*Conexão BD*/
        private const string _strConexao = "Database=destinocerto; Data Source=localhost; User Id=root; Allow User Variables=True";
        public Usuario BuscarId(int IdUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = "SELECT * FROM usuario WHERE IdUsuario=@IdUsuario";
            MySqlCommand comando = new MySqlCommand(Query, conexao);
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            MySqlDataReader reader = comando.ExecuteReader();

            Usuario UsuarioEncontrado = new Usuario();
            if (reader.Read())
            {
                UsuarioEncontrado.IdUsuario = reader.GetInt32("IdUsuario");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                    UsuarioEncontrado.Email = reader.GetString("Email");
                if (!reader.IsDBNull(reader.GetOrdinal("Telefone")))
                    UsuarioEncontrado.Telefone = reader.GetString("Telefone");
                if (!reader.IsDBNull(reader.GetOrdinal("Nascimento")))
                    UsuarioEncontrado.Nascimento = reader.GetString("Nascimento");
                if (!reader.IsDBNull(reader.GetOrdinal("Nivel")))
                    UsuarioEncontrado.Nivel = reader.GetString("Nivel");
            }
            conexao.Close();
            return UsuarioEncontrado;


        }

        /*Apagar*/
        public void RemoverUsuario(int IdUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "DELETE FROM usuario WHERE idUsuario = @IdUsuario";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        /*Inserir*/

        public void Insert(Usuario u)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "INSERT INTO usuario (Email, Telefone, Senha, Login, Nome, Nascimento, Nivel)";
            Query = Query + "VALUES (@Email, @Telefone, @Senha, @Login, @Nome, @Nascimento, @Nivel)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@Email", u.Email);
            comando.Parameters.AddWithValue("@Telefone", u.Telefone);
            comando.Parameters.AddWithValue("@Senha", u.Senha);
            comando.Parameters.AddWithValue("@Login", u.Login);
            comando.Parameters.AddWithValue("@Nome", u.Nome);
            comando.Parameters.AddWithValue("@Nascimento", u.Nascimento);
            comando.Parameters.AddWithValue("@Nivel", u.Nivel);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        /*Editar*/

        public void AtualizarUsuario(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "UPDATE usuario SET Email = @Email, Telefone = @Telefone, Senha = @Senha, Login = @Login, Nome = @Nome, Nascimento = @Nascimento, Nivel = @Nivel";
            Query = Query + " WHERE IdUsuario = @IdUsuario ";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@IdUsuario", u.IdUsuario);
            comando.Parameters.AddWithValue("@Email", u.Email);
            comando.Parameters.AddWithValue("@Telefone", u.Telefone);
            comando.Parameters.AddWithValue("@Senha", u.Senha);
            comando.Parameters.AddWithValue("@Login", u.Login);
            comando.Parameters.AddWithValue("@Nome", u.Nome);
            comando.Parameters.AddWithValue("@Nascimento", u.Nascimento);
            comando.Parameters.AddWithValue("@Nivel", u.Nivel);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        /*Listar*/

        public List<Usuario> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = "SELECT * FROM usuario";
            MySqlCommand comando = new MySqlCommand(Query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();

            while (reader.Read())
            {
                Usuario UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.IdUsuario = reader.GetInt32("IdUsuario");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = reader.GetString("Login");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = reader.GetString("Senha");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Telefone")))
                {
                    UsuarioEncontrado.Telefone = reader.GetString("Telefone");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    UsuarioEncontrado.Email = reader.GetString("Email");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Nivel")))
                {
                    UsuarioEncontrado.Nivel = reader.GetString("Nivel");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Nascimento")))
                {
                    UsuarioEncontrado.Nascimento = reader.GetString("Nascimento");
                }


                lista.Add(UsuarioEncontrado);
            }
            conexao.Close();
            return lista;
        }

        public Usuario ValidarLogin(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = " SELECT * FROM usuario WHERE Login=@Login AND Senha=@Senha ";
            MySqlCommand Comando = new MySqlCommand(Query, conexao);
            Comando.Parameters.AddWithValue("@Login", u.Login);
            Comando.Parameters.AddWithValue("@Senha", u.Senha);
            MySqlDataReader reader = Comando.ExecuteReader();

            Usuario UsuarioEncontrado = new Usuario();


            if (reader.Read())
            {

                UsuarioEncontrado.IdUsuario = reader.GetInt32("IdUsuario");

                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = reader.GetString("Login");

                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = reader.GetString("Senha");

                if (!reader.IsDBNull(reader.GetOrdinal("Telefone")))
                    UsuarioEncontrado.Telefone = reader.GetString("Telefone");

                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                    UsuarioEncontrado.Email = reader.GetString("Email");

                if (!reader.IsDBNull(reader.GetOrdinal("Nivel")))
                    UsuarioEncontrado.Nivel = reader.GetString("Nivel");

                if (!reader.IsDBNull(reader.GetOrdinal("Nascimento")))
                    UsuarioEncontrado.Nascimento = reader.GetString("Nascimento");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = reader.GetString("Nome");


            }
            conexao.Close();
            return UsuarioEncontrado;
        }



    }
}