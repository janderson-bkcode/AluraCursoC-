using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void TestandoClasseFile()
        {
            // Contar todas as linhas
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            //Mostrando dados das linhas
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            //Contar todos os bytes
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"");

            //Escrevendo conteudo e criando um arquivo
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");
        }
       
    }

}