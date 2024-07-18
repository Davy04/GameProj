using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProj.DB
{
    internal class CompanyDAL
    {
        public IEnumerable<Company> Listar()
        {
            var lista = new List<Company>();
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "SELECT * FROM Games";
            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string nomeGame = Convert.ToString(dataReader["Name"]);
                string bioGame = Convert.ToString(dataReader["Bio"]);
                int idGame = Convert.ToInt32(dataReader["Id"]);
                Company company = new(nomeGame, bioGame) { Id = idGame };

                lista.Add(company);
            }
            return lista;
        }

        public void Adicionar(Company company)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();
            
            string sql = "INSERT INTO Company (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", company.Name);
            command.Parameters.AddWithValue("@perfilPadrao", company.FotoPerfil);
            command.Parameters.AddWithValue("@bio", company.Bio);

            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
        }
    }
}
