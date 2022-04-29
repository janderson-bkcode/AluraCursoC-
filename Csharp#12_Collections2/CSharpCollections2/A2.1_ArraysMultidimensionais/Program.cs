using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._1_ArraysMultidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
                Arrays Multidimenionais
                Declarando uma "matriz retangular"
                Varrendo itens de um array multidimensional
                Obtendo limite inferior da dimensão com GetLowerBound()
                Obtendo limite superior da dimensão com GetUpperBound()
                Acessando itens de um array multidimensional
             */


            //Forma 1 de declaração de Array Multidmensional
            string[] resultados = new string[]
            {
                "Alemanha","Espanha","Itália",
                "Argentina","Holanda","França",
                "Holanda" , "Alemanha","Alemanha"
            };

            //Forma 2 de declaração de Array Multidmensional
            string[,] resultados2 = new string[4, 3];
            //{
            //    {"Alemanha","Espanha","Itália" },
            //    {"Argentina","Holanda","França"},
            //    {"Holanda" , "Alemanha","Alemanha" }
            //};

            //2014
            resultados2[0, 0] = "Alemanha";
            resultados2[1, 0] = "Argentina";
            resultados2[2, 0] = "Holanda";
            resultados2[3, 0] = "Brasil";

            //2010
            resultados2[0, 1] = "Espanha";
            resultados2[1, 1] = "Holanda";
            resultados2[2, 1] = "Alemanha";
            resultados2[3, 1] = "Uruguai";

            //2006
            resultados2[0, 2] = "Itália";
            resultados2[1, 2] = "França";
            resultados2[2, 2] = "Alemanha";
            resultados2[3, 2] = "Portugal";



            //foreach (var selecao in resultados2)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int copa = 0; copa <= resultados2.GetUpperBound(1); copa++)
            {
                int ano = 2014 - copa * 4;
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            for (int posicao = 0; posicao <= resultados2.GetUpperBound(0); posicao++)
            {
                for (int copa = 0; copa <= resultados2.GetUpperBound(1); copa++)
                {
                    Console.Write(resultados2[posicao, copa].PadRight(12));
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}
