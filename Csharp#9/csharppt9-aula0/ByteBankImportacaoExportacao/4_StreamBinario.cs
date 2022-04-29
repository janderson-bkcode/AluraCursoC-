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

        // Escrevendo valores em binário
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                //escritor.Write(false);
                //escritor.Write(true);
                escritor.Write(12346);//Numero da Agencia
                escritor.Write(10000);//NUmero da conta
                escritor.Write(4000.5); //Saldo da conta
                escritor.Write("Janderson Barbosa");// Titular
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadUInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Agência: {agencia}\nNumero da conta:{numeroConta}\nTitular: {titular}\nSaldo: {saldo}");
            }
        }



    }


}