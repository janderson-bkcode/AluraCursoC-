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
        static void Main(string[] args)
        {

          

            UsarStreamDeEntrada();
            EscritaBinaria();
            LeituraBinaria();
            //CriarArquivoComWriterFLush();
            //LidandoComFilesStreamDiretamente();
            //CriarArquivoComWriter();
            
            Console.ReadLine();

        }

       


    }
}
