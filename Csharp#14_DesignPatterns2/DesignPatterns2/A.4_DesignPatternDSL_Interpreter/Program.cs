using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignPatternDSL_Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(10)),new Soma(new Numero(30),new Numero(20)));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            Console.ReadLine();

        }
    }
}
