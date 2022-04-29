using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{   // Aula 09 Entradas e Saidas IO FileStream
    // Partial class
    // para usar indicando que temos métodos e partes de uma
    //  classe em outros arquivos
    // Nessa caso o arquivo 1_LidandoComFileStreaDiretamente.cs
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using(var fs = new FileStream("EntradaConsole.txt",FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer,0,bytesLidos);
                    fs.Flush();
                    Console.WriteLine($"Bytes lidos na console:{bytesLidos}");
                }
                
            }
        }

    }

}