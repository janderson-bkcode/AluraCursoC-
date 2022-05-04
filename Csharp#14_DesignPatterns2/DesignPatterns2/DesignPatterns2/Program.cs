using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abrindo conexão
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id =root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();

            //Variavel que representa o comando a ser executado
            IDbCommand comando =  conexao.CreateCommand();
            comando.CommandText = "select * from tabela;";

        }
    }
}
