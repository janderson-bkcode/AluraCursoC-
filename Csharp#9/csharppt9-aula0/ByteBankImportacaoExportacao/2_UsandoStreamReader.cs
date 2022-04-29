using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    // Partial class
    // para usar indicando que temos métodos e partes de uma
    //  classe em outros arquivos
    // Nessa caso o arquivo Program.cs
    partial class Program
    {
        #region StreamReader
        static void UsandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";
            //Quando usamos Using aninhados tiramos a chave do externo e recuamos a identação 
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
                //Não precisa definir o Enconding, apesar que possui sobrecarga abaixo
            using (var leitor = new StreamReader(fluxoDeArquivo/*,Encondig.UTF32*/))
            {
                // var linha = leitor.ReadLine(); // Lerá apenas a primeira linha, retorna sting
                //   var lerTudo = leitor.ReadToEnd();// Lerá até o final do arquivo,retorna string
                //   var lerByte = leitor.Read(); // mostrará int o valor byte, retorna int
                //   Console.WriteLine(linha);


                // Laço para apresentar todas as linhas até chegar no final do arquivo
                while (!leitor.EndOfStream)// Enquanto não for o fim do arquivo faça:
                {
                    var linha2 = leitor.ReadLine();
                    var ContaCorrente = ConverterStringParaContaCorrente(linha2);
                    var msg = $"Titular: {ContaCorrente.Titular.Nome} Conta numero: {ContaCorrente.Numero}, ag.: {ContaCorrente.Agencia},Saldo: {ContaCorrente.Saldo} ";
                    Console.WriteLine(msg);
                    // Console.WriteLine(linha2);
                }
            }
        }
        #endregion
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(' ');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            //Convertendo campos para Int para colocar no parametro de ContaCorrente
            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;

        }

    }
}
