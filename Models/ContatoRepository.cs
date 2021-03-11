using System.Collections.Generic;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class ContatoRepository
    {
        /*Conexão BD*/
        private const string _strConexao = "Database=destinocerto; Data Source=localhost; User Id=root; Allow User Variables=True";


        /*Inserir*/

        public void Insert(Contato y)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "INSERT INTO contato (Email, Telefone, Duvida)";
            Query = Query + "VALUES (@Email, @Telefone, @Duvida)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@Email", y.Email);
            comando.Parameters.AddWithValue("@Telefone", y.Telefone);
            comando.Parameters.AddWithValue("@Duvida", y.Duvida);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

    }
}