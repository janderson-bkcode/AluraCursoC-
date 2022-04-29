using System.IO;
using System.Text;
using System;

namespace ByteBankImportacaoExportacao
{   // Aula 09 Entradas e Saidas IO FileStream

    // Partial class
    // para usar indicando que temos métodos e partes de uma
    //  classe em outros arquivos
    // Nessa caso o arquivo Program.cs
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50, Gustavo Santos";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }
            
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquivo))
            {
                escritor.Write("456,78945,4785.50, Pedro Silva");
            }
                
            
        }

        static void CriarArquivoComWriterFLush()
        {
            var caminhoNovoArquivo = "contasExportadas2.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine("456,78945,4785.50, Pedro Silva");
                    escritor.Flush();// Despeja o buffer para o Stream diretamente no arquivo no HD em execução
                    Console.WriteLine($"Linha {i} foi Adicionada no arquivo,Digite para add mais");
                    Console.ReadLine();
                }
                
            }


        }
    }
}