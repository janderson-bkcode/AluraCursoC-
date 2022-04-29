using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31OPoderdosSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //Duas propriedades do Set
            //1. Não permite Duplicidade
            //2. Os elementos não são mantidos em orderm específica

            //Declarando set de Alunos
            ISet<string> alunos = new HashSet<string>();
            // adicionando: vanessa, ana,rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos); //Não gera as informações
            Console.WriteLine(string.Join(",",alunos));

            //Qual a diferença para uma lista ? Veremos agora
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gusiken");
            Console.WriteLine(string.Join(",", alunos));

            // e a ordem?
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");// Não é adicionado no final do conjunto e sim no lugar da ana , não sabemos onde ficará
            Console.WriteLine(string.Join(",", alunos));

            //Adicinando Fabio gushiken novamente
            alunos.Add("Fabio Gusiken");
            alunos.Add("Ana Paula");
            Console.WriteLine(string.Join(",", alunos));//Imprime mas não adiciona
            Console.ReadLine();


            //Qual a vantagem do set em relação a lista?

            //É mais rápido para busca de elementos devido a tabela de espalhamento, lista você varre do 1º ao ultimo elemento 
            
            //Desempenho HashSet X List : escalabilidade x memória

            
            
            
            //Ordenando: Sort
            //alunos.Sort() ; Erro porque ISet não implemente Sort e Icomparable

            List<string> alunosEmLista = new List<string>(alunos);

            alunosEmLista.Sort();

            Console.WriteLine(string.Join(",",alunosEmLista));

            Console.ReadLine();



            
        }
    }
}
