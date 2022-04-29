using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3._1_ConsultandoCollections
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Problema : Obter os nomes dos meses do ano
            // que tem 31 dias. em Maiusculo e em ordem alfabetica

            List<Mes> meses = new List<Mes>()
            {
                new Mes("Janeiro",31),
                new Mes("Fevereiro",28),
                new Mes("Março",31),
                new Mes("Abril",30),
                new Mes("Maio",31),
                new Mes("Junho",30),
                new Mes("Julho",31),
                new Mes("Agosto",31),
                new Mes("Setembro",30),
                new Mes("Outubro",31),
                new Mes("Novembro",30),
                new Mes("Dezembro",31)
            };

            //meses.Sort();
            //foreach (var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }

            //}

            //LINQ = Consulta integrada a linguagem

            //Montagem da consulta
            IEnumerable<string>
                consulta = meses
                            .Where(m => m.Dias == 31)
                            .OrderBy(m => m.Nome)
                            .Select(m=> m.Nome.ToUpper());
            
            //Uso da consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            //Pegar o 1º trimestre
            var consulta2 = meses.Take(3);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }

            //Pegar os meses depois do primeiro trimestre
            var consulta3 = meses.Skip(3);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Pegar os meses do terceiro trimestre
            var consulta4 = meses.Skip(6).Take(3);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            };
            Console.WriteLine();

            //Pegar os meses até que o mês comece com a letra 'S', depois de setembro não é impresso
            var consulta5 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Pular os meses até que o mês comece com a letra 'S', imprime depois de Setembro
            var consulta6 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();

            List<string> list = new List<string>();
            
        }

       public class Mes : IComparable
        {
            public Mes(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }

            public string Nome { get; private set; }
            public int Dias { get; private set; }

            public int CompareTo(object obj)
            {
               Mes outroMes = obj as Mes;

                return this.Nome.CompareTo(outroMes.Nome);
            }

            public override string ToString()
            {
                return $" {Nome} - {Dias}";
            }

        }

        public class Mes2 : IComparable
        {

            public Mes2(string nome , int dias)
            {
                Nome = nome;
                Dia = Dia;
            }
            public string Nome { get; set; }
            public int Dia { get; set; }



            public int CompareTo(object obj)
            {
                Mes outromes = obj as Mes;
                return Nome.CompareTo(outromes.Nome);
            }

            public override string ToString()
            {
                return $" Nome {Nome} - Dias {Dia}";
            }
        }

    }
}
