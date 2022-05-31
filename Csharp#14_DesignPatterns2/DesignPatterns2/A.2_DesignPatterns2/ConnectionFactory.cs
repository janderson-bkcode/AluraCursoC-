using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DesignPatterns2.Aula01
{   /// <summary>
    /// Classe que tem como Propósito Abri conexão com Banco de Dados 
    /// Funciona como Design Pattern Factory
    /// </summary>
    internal class ConnectionFactory
    {   
        public IDbConnection GetConnection()
        {
            //Abrindo conexão
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id =root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;

        }
    }
}
