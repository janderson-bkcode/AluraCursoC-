using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);
            Console.ReadLine();

        }
    }
}
