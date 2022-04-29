using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(1234,1234);
            //ContaCorrente conta2 = new ContaCorrente(12345, 54321);
            //Console.WriteLine(conta.Agencia);
            //Console.ReadLine();


            //Aula 05 Nuget
            DateTime DataFimPagamento = new DateTime(2020, 6, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
 