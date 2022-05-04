using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadorDeDescontosBaseHandler calculador = new CalculadorDeDescontosBaseHandler();

            Orcamento orcamento = new Orcamento(6000);
            orcamento.AdicionaItem(new Item("CANETA", 500));
            orcamento.AdicionaItem(new Item("LAPIS", 500));
            orcamento.AdicionaItem(new Item("Geladeira", 500));
            orcamento.AdicionaItem(new Item("Microondas", 500));
            orcamento.AdicionaItem(new Item("Faca", 500));
            orcamento.AdicionaItem(new Item("Bola", 500));
            orcamento.AdicionaItem(new Item("Copo", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadLine();
        }
    }
}
