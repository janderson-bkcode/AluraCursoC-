using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A53Queue
{
    internal class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            Enfileirar("Van");
            Enfileirar("kombi");
            Enfileirar("Guinho");
            Enfileirar("Pickup");
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();



            Console.ReadLine();
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($" Entrou na Fila : {veiculo}");
            pedagio.Enqueue(veiculo);
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento ");
                }
            }
            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"\nSaiu da fila {veiculo}");
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("\nCarros na Fila:");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
