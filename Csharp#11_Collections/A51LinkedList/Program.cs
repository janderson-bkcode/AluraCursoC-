using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "Abacate","banana","caqui","damasco","figo"
            };

            //Vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //Porém inserir no meio da lista exige mais esforço computacional
            //Porque os elementos tem que ser deslocados para darem
            //espaço ao novo elemento
            //E ser tivermos que remover esse elemento , os elementos
            //seguintes precisam ser deslocados de novo

            //Quanto maior a lista , mais ineficiente é a inserção
            //e remoção de elementos no meio dela
            //Que coleção é apropriada para inserção/remoção rápida?

            //Apresentando Lista Ligada (Linked List):
            // - Elementos não precisam estar em sequencia em memória
            // - Cada elemento sabe quem é o anterior e o próximo
            // - Cada elemento é um "nó" que contém um valor

            //Como a ordem é mantida? Usando Ponteiros

            //Instanciando uma nova lista ligada : dias da semana

            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("quarta");
            // "quarta" é o primeiro elemento da lista ligada

            //Cada elemento é um nó : LinkedListNode<T>

            //Mas e o valor "quarta"? Está na propriedade d4.Value

            Console.WriteLine("D4.Value: " + d4.Value);
            //E para adicionar mais itens? LinkedList não possui Add !
            //1. Como Primeiro nó
            //2. Como ultimo nó
            //3. Antes de um nó conhecido
            //4. Depois de um nó conhecido

            //Vamos adicionar segunda, antes da quarta;
            var d2 = dias.AddBefore(d4, "segunda");

            //Agora d2 e d4 estão ligados
            // d2.Next é igual a d4

            //Continuando com nossa lista ligada,
            //Vamos adicionar terça depois de segunda
            var d3 = dias.AddAfter(d2, "terça");

            //Percebea que os ponteiros, ou referências
            // de d2 e d4 foram redirecionados para d3!!
            //Vamos adicionar sexta depois de quarta

            //Sexta depois da quarta
            var d6 =  dias.AddAfter(d4, "sexta");

            //Sabado depois da sexta
            var d7 = dias.AddAfter(d6, "sabado");

            //Quinta antes da sexta
            var d5 = dias.AddBefore(d6, "quinta");

            //Domingos antes da segunda

            Console.WriteLine("Imprimindo todos os dias da lista\n");
            var d1 = dias.AddBefore(d2, "Domingo");

            //Agora vamos imprir a lista ligada

            foreach (var dia  in dias)
            {
                Console.WriteLine(dia);
            }

            //LinkedList não dá suporte ao acesso de indice: dias[0]
            //Por isso podemos fazer um laço foreach mas não um for!
            //dias[0] sintaxe inválida

            //Buscando um elemento pelo valor na lista Linkada
            var quarta = dias.Find("quarta");

            //Para removermos um elemento podemos tanto 
            //remover pelo valor quanto pela referência do LinkedListNode
            //dias.Remove("quarta") ou dias.Remove(d4);

            dias.Remove("quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }


            Console.ReadLine();
            

        }
    }
}
