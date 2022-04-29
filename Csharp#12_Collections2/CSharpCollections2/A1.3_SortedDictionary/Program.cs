using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._3_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            NO SortedSet, temos uma árvore binária somente na parte de valores, 
            assim como no SortedDictionary.
            O dicionário não contém chaves, ou seja, 
            não é uma coleção associativa. Os valores, são as 
            próprias chaves dos elementos de um SortedSet.
            Ordena por valores
            */

            //Conjuntos de Alunos:

            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");

            alunos.Add("Fabio Gushiken");

            //Nâo imprime valores duplicados
            alunos.Add("Fabio Gushiken");

            //Não será imprimido devido a sobrecarga da classe ComparadorMinusculo que implementa interface IComparer
            alunos.Add("FABIO GUSHIKEN");


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.ReadLine();

            ISet<string> outroConjunto = new HashSet<string>();

            //Este conjunto é subconjunto do outro? ISubsetOf
            //Alunos está contindo em outroConjunto?
            alunos.IsSubsetOf(outroConjunto);

            //Este conjunto é superConjunto do outro ? IsSuperSetOf
            // No caso outroConjunto está contido em alunos?
            alunos.IsSupersetOf(outroConjunto);

            //Os conjuntos contêm os mesmos elementos? SetEquals
            alunos.SetEquals(outroConjunto);

            //Subtrai os elementos da outra coleção que também estão em outro
            alunos.ExceptWith(outroConjunto);

            //Intersecção dos conjuntos 
            alunos.IntersectWith(outroConjunto);

            //Somente em um ou outro conjunto - SymmetricExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            //União dos conjuntos
            alunos.UnionWith(outroConjunto);



        }
    }

    /// <summary>
    /// Classe para o SortedSet comparar valores iguais 
    /// de string maiúscula e minúscula
    /// </summary>
    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //InvariantCulture para comparar Maiúsculas e Minúsculas e enxergá-las como iguais na escrita
            return string.Compare(x, y,StringComparison.InvariantCultureIgnoreCase);
        }


    }


}
