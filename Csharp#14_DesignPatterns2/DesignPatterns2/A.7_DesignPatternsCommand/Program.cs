using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio",500.0);
            Pedido pedido2 = new Pedido("Marcelo", 200.0);


            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));
            fila.Processa();

            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
