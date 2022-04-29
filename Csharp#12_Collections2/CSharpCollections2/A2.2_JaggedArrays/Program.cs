using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2._2_JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Matrizes Denteadas
            Declarando uma "matriz de matrizes"
            Inicializando uma matriz denteada
            Varrendo itens de uma matriz denteada
            Acessando itens de uma matriz denteada
            */



            //Familia 1: Familia Flinstones
            //Familia 2: Familia Simpsons
            //Familia 3: Familia Dona Florinda

            //Jagged Array = Array denteado ou serrilhado


            string[][] familias = new string[3][];
            //{
            //    { "Fred","Wilma","Pedrita"}
            //    {"Homer","Marge","Lisa","Bart","Maggie" },
            //    {"Florinda","Kiko" }
            //};

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",",familia));
            }

            Console.ReadLine();
        }
    }
}
