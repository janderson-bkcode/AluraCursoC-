using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._1_Covariancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversões de coleções

            Console.WriteLine("String para object");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);


            //-----------------------------------------------------------
            Console.WriteLine("List<string> para List<object>");

            IList<string> listaMeses = new List<string>()
            {
                "Janeiro","Fevereiro","Março",
                "Abril","Maio","Junho",
                "Julho","Agosto","Setembro",
                "Outubro","Novembro","Dezembro"
            };

            //  IList<object> listobj = listaMeses; => Não é permitido ,
            //  IList não permite conversão de tipos
            Console.WriteLine();

            //-----------------------------------------------------------
            Console.WriteLine("Array de string[] para array de object[]");

            string[] arrayMeses = new string[] {
                "Janeiro","Fevereiro","Março",
                "Abril","Maio","Junho",
                "Julho","Agosto","Setembro",
                "Outubro","Novembro","Dezembro"
            };
            object[] arrayobj= arrayMeses; //Convariância de array

            foreach (var item in arrayobj)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(string.Join(",",arrayobj));

            arrayobj[0] = "Primeiro Mês";
            Console.WriteLine(arrayobj[0]); // Imprime Primeiro Mês
            Console.WriteLine();

            //Abaixo Gera exception de arrayTypeMismatchException
            // porque arrayobj aceita somente valores strings agora devido
            // a covariância criada
            // Deve ser evitado, porque o arrayobj que é do tipo object
            // e devia aceitar outros tipos agora só aceita string

            arrayobj[0] = 12345;
            Console.WriteLine(arrayobj[0]); //ArrayTypeMismatchException



            //-----------------------------------------------------------
            Console.WriteLine("IList<string> para IEnumerable<object>");

            //Permite a conversão de string para object porque IEnumerable não possui indexador
            //Inumerable<object> é Covariante e armazena listas de qualquer tipo
            IEnumerable<object> enumObj =listaMeses; //Covariância

            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
