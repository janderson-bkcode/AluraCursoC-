using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignaPatternsDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aplicação do Design Pattern Decorator conforme classe Abstrata Imposto
            Imposto iss = new ISS_Strategy(new ICMS_Strategy());

            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }


    }
}
