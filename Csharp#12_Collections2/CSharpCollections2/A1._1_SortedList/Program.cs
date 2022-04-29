using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._1_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            Dictionary:
            ----------------------------------------
          
            As chaves, que estão na primeira coleção, 
            são armazenadas de uma forma não-ordenada. 
            Isso significa que, a posição que cada chave ocupa na memória, 
            independe da sua ordem de inserção.
            A ordem dependerá do seu código de espalhamento (ou "hash"),
            que é calculado para direcionar um item para determinado lugar na memória, um bucket, 
            ou uma gaveta, onde cada informação é organizada, para ser recuperada posteriormente.
            -----------------------------------------

            SortedList:
            --------------------------------------------
            Possui duas listas
            Temos uma estrutura diferente de armazenamento de chaves e valores. 
            Não teremos a coleção que utiliza o "hash", em vez disso, haverá uma lista 
            automaticamente ordenada. Ou seja, cada vez que inserimos um valor, ele será ordenado automaticamente.
            Em outra lista, serão armazenados os valores.
            ---------------------------------------------
          */



            //Vamos criar um dicionario de Alunos
            //VT ,Vanessa,34672
            //Al , Ana,5617
            //Rn,Rafael 17645
            //WM,Wanderson, 11287


            IDictionary<string,Aluno> alunos = new Dictionary<string,Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 34672));

            //Imprimindo

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("Antes da remoção");
            Console.ReadLine();

            //Removendo aluno : AL
            alunos.Remove("AL");

            //Adicionando novo aluno : MO

            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Console.WriteLine("Depois da remocação e adição");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno );
            }
            Console.ReadLine();


            //Apresentando uma nova coleção ... SortedList e copiando

            Console.WriteLine("Sorted List");
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

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
