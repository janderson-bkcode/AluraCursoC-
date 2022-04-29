using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*
             SortedDictionary
             A chave é estruturada em Arvore em profundidade 
            Cada um dos nós aponta para um ou dois valores, ou, ainda, para nenhum valor.
            Ordena por chaves
             */

            Console.WriteLine("Sorted List");
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 34672));
            Console.WriteLine();
            foreach (var aluno in sorted)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadLine();
        }
    }

}
