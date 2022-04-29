using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            TestaLinq();

            Console.ReadLine();
        }

        #region TesteLinq
        public static void TestaLinq()
        {
            // Lista de Generos
            List<Genero> generos = new List<Genero>()
            {
                new Genero{Id = 1,nome = "Samba"},
                new Genero {Id = 2,nome ="Rap"},
                new Genero{Id = 3,nome = "Trap"},
                new Genero{Id=4,nome ="Rock"}

            };
            //Query de consulta LInq
            var query = from g in generos
                        where g.nome.Contains("Rap")
                        select g;

            //Listando e apresentando dados
            foreach (var genero in query)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.nome);
            }

            // Lista de musicas
            var musicas = new List<Musica>
            {
                    new Musica { id = 1, Nome = "Lose yourself", GeneroId = 2, AutorId = 1,AlbumID =1},
                    new Musica { id = 2, Nome = "Not afraid", GeneroId = 2,AutorId =1,AlbumID =2},
                    new Musica { id = 3, Nome = "777-666", GeneroId = 3},
                    new Musica { id = 4, Nome = "Nothing Else Mathers", GeneroId = 4}
            };

            //Query de consulta LInq
            var musicaQuery = from m in musicas
                              select m;
            //Listando e apresentando dados
            foreach (var musica in musicas)
            {
                Console.WriteLine($"ID {musica.id} Nome: {musica.Nome} GeneroID:{musica.GeneroId}");
            }

            // Juntando as duas listas como tabelas para consulta 

            var musicQuery = from m in musicas
                             join g in generos on m.GeneroId equals g.Id
                             select new { m, g };

            foreach (var musica in musicQuery)
            {
                Console.WriteLine("{0}\t{1}\t{2}", musica.m.id, musica.m.Nome, musica.g.nome);
            }

            // Lista de Autores
            List<Autor> autores = new List<Autor>()
            {
                new Autor{Id =1,Nome="Eminem" }

            };

            //Lista de Album

            List<Album> albuns = new List<Album>() {

            new Album{id=1,nome="The Eminem Show",AutorId = 1},
            new Album{id=2,nome="Recovery",AutorId = 1},

            };

            //Lista de Colecão

            List<Colecao> colecao = new List<Colecao>() {

            new Colecao{id=1,nome="Janderson",AlbumId=1},

            };

            //Join com três 
            var autorquery = from a in autores
                             join m in musicas on a.Id equals m.AutorId
                             join ab in albuns on  a.Id equals ab.AutorId
                             //     join gm in generos on m.GeneroId equals gm.Id
                             select new {a,m,ab }; // lista de object do tipo anônimo

            var autorquery2 = from pro in autorquery
                              select new { pro.a };

            foreach (var autor in autorquery)
            {
                Console.WriteLine($"Autor {autor.a.Nome} Musicas {autor.m.Nome} Albuns {autor.ab.nome}");
            }


            //foreach (var autor in autorquery)
            //{

            //    Console.WriteLine($"Musica: {autor.m.Nome} , Genero: {autor.g.nome}, Autor: {autor.a.Nome}");
            //}

           

           
        }

        static void testaLinq2()
        {
            List<int> numbers = new List<int>()
            {
                5,4,3,2,1,0,8,9,9,8,8,8,8,8
            };

            // The query variables can also be implicity typed by using var

            //Query #1

            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

            //Query#2
            IEnumerable<int> filteringQuery2 =
                 from num in numbers
                 where num < 3 || num > 7
                 orderby num ascending
                 select num;

            //Query #3
            string[] groupingQuery = { "carrots", "cabbage", "brocolli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            // Query #4
            List<int> numbers1 = new List<int>() { 5, 4, 23, 2, 32322 };
            List<int> numbers2 = new List<int>() { 22, 22, 33, 2244 };

            double average = numbers1.Average();//Computa média

            Console.WriteLine(average);

            //Query 5
            IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);

            //Query6
            IEnumerable<int> largerNumberQuery = numbers2.Where(c => c > 15);
            foreach (var item in largerNumberQuery)
            {
                Console.WriteLine(item);
            }

            //Query 7

            //Using a query expression with method sintax
            int numCount1 = (
                from num in numbers1
                where num < 3 || num > 7
                select num
           ).Count();

            //Better: Create a new variable to store
            //The method call result

            IEnumerable<int> numberQuery =
                from num in numbers1
                where num < 3 || num > 7
                select num;

            int numCount2 = numberQuery.Count();

            foreach (var item in numberQuery)
            {
                Console.WriteLine(item);
            }
            //Var
            var numCount3 = (
                from num in numbers2
                where num < 3 || num > 7
                select num
         ).Count();

            // forma clean com var
            var numCount4 = numbers1.Where(n => n < 3 || n > 7).Count();

            //forma clean tipada
            int numCount5 = numbers2.Where(n => n < 3 || n > 7).Count();
        }
        #endregion
        #region Métodos de Teste

        #region Metódo Testando o Sort()
        static void TestaSort()
        {

            // Ordenação de lista de String
            var nomes = new List<string>()
            {
                "Janderson",
                "Bernardo",
                "Bruno",
                "Nicolas"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            // Apresentará erro porque não consegue ordenar 
            //ver método Abaixo
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(1234,5666),
                new ContaCorrente(1235,5777),
                new ContaCorrente(1236,5888)
            };



        }

        static void TestaSortContaCorrente()
        {
            /*-------------
             * SORT
             * ------------
             */

            /* Só funciona devido ter implementado na classe Conta Corrente
               a interface Icomparable e o método CompareTo

             */

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(1234,5666),
                new ContaCorrente(1235,5777),
                new ContaCorrente(1236,5888),

            };

            //Ordenação via implementação do Icomparable e método CompareTo
            // contas.Sort();

            // Testando método de ordenação por agencia 
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var item in contas)
            {
                Console.WriteLine($"Conta numero {item.Numero} , Ag.{item.Agencia}");
            }

            /*-------------
             * ORDER BY
             * ------------
             */

            //Usando OrderBy para ordenar a contaCorrente pelo Numero sem precisar mexer na classe Contacorrente

            //    var  contasOrdenadas4 = contas.OrderBy(conta => conta.Numero);
            //    IOrderedEnumerable<ContaCorrente> contas = contas.OrderBy<ContaCorrente, int>(conta => conta.Numero);
            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                    contas.OrderBy(conta =>
                 {
                     if (conta == null)
                     {
                         return int.MaxValue;
                     }

                     return conta.Numero;
                 });

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta Numero{conta.Numero}. ag.{conta.Agencia}");
                }

            }

            /*-------------
            * LINQ WHERE
            * ------------
            */

            // forma  verbosa
            IEnumerable<ContaCorrente> contasNaoNulas = contas.Where(conta => conta != null);

            IEnumerable<ContaCorrente> contasNaoNulas2 = contas.Where(conta => conta != null);

            IOrderedEnumerable<ContaCorrente> contasOrdenadas2 =
                contasNaoNulas.OrderBy(conta => conta.Numero);

            IOrderedEnumerable<ContaCorrente> contasOrdAgencia =
                contasNaoNulas2.OrderBy(conta => conta.Agencia);


            // forma menos verbosa
            var contasOrdenadas3 = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas3)
            {
                Console.WriteLine($"Conta Numero{conta.Numero}. ag.{conta.Agencia}");
            }

        }



        #endregion
        #region Metodo Teste Var
        static void TestaVar()

        {
            var resultado = SomarVarios(1, 2, 34, 5);
            var nomes = "Alura";
            var conta = new ContaCorrente(1234, 12324);
            var lista = new List<GerenciadorBonificacao>();

        }
        #endregion
        #region Metodos de Extensão Aula #8
        static void TestaMetodoExtensao()
        {
            // Aula C#8  List
            List<int> idade = new List<int>();
            idade.Add(5);
            // idade.AddRange( 1, 2, 3, 9 ); Não funciona porque não espera argumento do tipo Paramns
            idade.AddRange(new int[] { 1, 2, 3, 9 });
            idade.Remove(5);

            for (int i = 0; i < idade.Count; i++)
            {
                Console.WriteLine($"Mostrando valores de {idade[i]}");
            }
            Console.ReadLine();


            //Chamando método static "AdicionarVarios" através da classe
            ListExtensoes.AdicionarVarios(idade, 1, 2, 3, 4, 5, 6);

            //Chamando método static agora como método de extensão
            //Repare que o primeiro parametro é do tipo list e fica implícito
            //Já que idade é do tipo List, coloque apenas o 2º paramêtro
            //nesse caso os valores int Array

            idade.AdicionarVarios(5, 4448, 78787, 222);// Apenas colocando valores do params de forma implícita tipo list
            idade.AdicionarVarios(itens: new int[] { 5, 4448, 78787, 222 }); //Usando parametro opcional
            idade.AdicionarVarios2(1, 2, 3, 4, 5);

            Console.WriteLine("Adicionado via parametro opcional");
            for (int i = 0; i < idade.Count; i++)
            {
                Console.WriteLine($"Mostrando valores de {idade[i]}");
            }
            Console.ReadLine();




            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            Console.WriteLine(SomarVarios(1, 2, 45));


            Console.ReadLine();
        }
        static void TestaMetodoExtensaoGenerico()
        {
            List<int> idades = new List<int>();
            idades.AdicionarVarios2(1, 2, 3, 4, 5, 5, 6);

            List<string> nomes = new List<string>();

            nomes.AdicionarVarios2("janderson", "Bernardo", "Caio", "Bruno");


        }
        #endregion
        #region Metodos Arrays e Genéricos Aula #7
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }


        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }



        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
        #endregion
        #endregion
    }
}




