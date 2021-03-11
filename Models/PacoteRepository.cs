using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class PacoteRepository
    {
        /*Conexão BD*/
        private const string _strConexao = "Database=destinocerto; Data Source=localhost; User Id=root; Allow User Variables=True";

        public Pacote BuscarId(int IdPacote)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = "SELECT * FROM pacote WHERE IdPacote=@IdPacote";
            MySqlCommand comando = new MySqlCommand(Query, conexao);
            comando.Parameters.AddWithValue("@IdPacote", IdPacote);
            MySqlDataReader reader = comando.ExecuteReader();

            Pacote PacoteEncontrado = new Pacote();
            if (reader.Read())
            {
                PacoteEncontrado.IdPacote = reader.GetInt32("IdPacote");

                if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                    PacoteEncontrado.Destino = reader.GetString("Destino");
                if (!reader.IsDBNull(reader.GetOrdinal("Partida")))
                    PacoteEncontrado.Partida = reader.GetString("Partida");
                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                    PacoteEncontrado.Retorno = reader.GetString("Retorno");
                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                    PacoteEncontrado.Saida = reader.GetString("Saida");
                if (!reader.IsDBNull(reader.GetOrdinal("Preco")))
                    PacoteEncontrado.Preco = reader.GetDouble("Preco");
                if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                    PacoteEncontrado.Usuario = reader.GetInt32("Usuario");

            }
            conexao.Close();
            return PacoteEncontrado;


        }

        /*Apagar*/
        public void RemoverPacote(int IdPacote)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "DELETE FROM pacote WHERE idPacote = @IdPacote";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@IdPacote", IdPacote);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        internal void Remover(int idPacote)
        {
            throw new NotImplementedException();
        }

        /*Inserir*/

        public void Insert(Pacote x)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "INSERT INTO pacote (Destino, Partida, Saida, Retorno, Preco, Usuario)";
            Query = Query + "VALUES (@Destino, @Partida, @Saida, @Retorno, @Preco, @Usuario)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@Destino", x.Destino);
            comando.Parameters.AddWithValue("@Partida", x.Partida);
            comando.Parameters.AddWithValue("@Saida", x.Saida);
            comando.Parameters.AddWithValue("@Retorno", x.Retorno);
            comando.Parameters.AddWithValue("@Preco", x.Preco);
            comando.Parameters.AddWithValue("@Usuario", x.Usuario);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        /*Editar*/

        public void EditarPacote(Pacote x)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "UPDATE pacote SET Destino = @Destino, Partida = @Partida, Saida = @Saida, Retorno = @Retorno, Preco = @Preco, Usuario = @Usuario";
            Query = Query + "WHERE IdPacote = @IdPacote";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@IdPacote", x.IdPacote);
            comando.Parameters.AddWithValue("@Destino", x.Destino);
            comando.Parameters.AddWithValue("@Partida", x.Partida);
            comando.Parameters.AddWithValue("@Saida", x.Saida);
            comando.Parameters.AddWithValue("@Retorno", x.Retorno);
            comando.Parameters.AddWithValue("@Preco", x.Preco);
            comando.Parameters.AddWithValue("@Usuario", x.Usuario);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        /*Listar*/

        public List<Pacote> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "SELECT * FROM pacote";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            List<Pacote> listpacote = new List<Pacote>();

            while (reader.Read())
            {
                Pacote pacote = new Pacote();

                pacote.IdPacote = reader.GetInt32("idPacote");

                if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                {
                    pacote.Destino = reader.GetString("Destino");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Partida")))
                {
                    pacote.Partida = reader.GetString("Partida");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                {
                    pacote.Saida = reader.GetString("Saida");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                {
                    pacote.Retorno = reader.GetString("Retorno");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Preco")))
                {
                    pacote.Preco = reader.GetDouble("Preco");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                {
                    pacote.Usuario = reader.GetInt32("Usuario");
                }
                listpacote.Add(pacote);

            }
            conexao.Close();

            return listpacote;
        }
    }
}