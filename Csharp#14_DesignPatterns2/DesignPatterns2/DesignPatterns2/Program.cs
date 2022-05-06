﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.TesteTransporte;

namespace DesignPatterns2.Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Abrindo conexão usando a classe ConnectionFactory
            //IDbConnection conexao = new ConnectionFactory().GetConnection();

            ////Variavel que representa o comando a ser executado
            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela;";

            TesteTransporte();
        }

        public static void TesteTransporte()
        {
            RoadLogisticTransportCreator rd = new RoadLogisticTransportCreator();
            rd.createTransport();

            SeaLogisticsTransportCreator s = new SeaLogisticsTransportCreator();
            var x = s.createTransport();

            x.deliver();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
