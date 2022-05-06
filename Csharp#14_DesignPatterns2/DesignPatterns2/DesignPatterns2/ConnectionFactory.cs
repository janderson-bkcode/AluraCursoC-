﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{   /// <summary>
    /// Classe que tem como Propósito Abrir conexão com Banco de Dados.
    /// Funciona como Design Pattern Factory
    /// Isola criação do objetos complicados no caso <see cref="IDbConnection"/>
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
