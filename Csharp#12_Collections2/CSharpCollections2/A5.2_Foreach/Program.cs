using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._2_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //ForEach itera qualquer coleção que implementa IEnumerable

            /*
           Clicaremos sobre a classe List e utilizaremos o comando "Alt + F12". 
            Feito isso, poderemos observar a sua definição.
            Ela implementa a interface IEnumerable, que é fundamental para a instrução.
            Utilizando o atalho "Alt + F12" sobre esta interface vemos que, 
            dentro dela, há um método chamado 
            GetEnumerator(), que por sua vez retorna um IEnumerator<T>.

            Na classe List há um struct Enumerator que 
            propriedade Current - que é o elemento atual de uma varredura com a instrução foreach, 
            e um método MoveNext, 
            que é utilizado para mover o ponteiro para o próximo elemento desta varredura.
            Enumera os elementos de uma System.Collections.Generic.List`1.
           */

            var meses = new List<string>()
            {
                "Janeiro","Fevereiro","Março",
                "Abril","Maio","Junho",
                "Julho","Agosto","Setembro",
                "Outubro","Novembro","Dezembro"
            };


            foreach (var mes in meses)
            {
                //mes = mes.ToUpper(); => Não é permitido modificar variavel do foreach
                //meses[0] = meses[0].ToUpper(); => //Gera exception porque não pode mofidicar coleção que esta sendo enumerada
                Console.WriteLine(mes);
            }

            var meses2 = new string[]
            {
                "Janeiro","Fevereiro","Março",
                "Abril","Maio","Junho",
                "Julho","Agosto","Setembro",
                "Outubro","Novembro","Dezembro"
            };

            foreach (var item in meses2)
            {   
                //Com arrays ele permite 
                //Internamente ele transforma num laço for
                meses2[0] = meses2[0].ToUpper();
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
