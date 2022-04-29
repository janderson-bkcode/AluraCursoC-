using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            TestaArrayDeContaCorrente();
            Console.WriteLine("Ok");
            Console.ReadLine();
        }

        static void TestaListaGenerica()
        {
            //Usando classe Lista com tipos Genéricos
            Lista<int> idades2 = new Lista<int>();
            Lista<string> stras = new Lista<string>();

            idades2.Adicionar(60);
            idades2.AdicionarVarios(20, 30, 50);


            for (int i = 0; i < idades2.Tamanho; i++)
            {
                int idadeAtual = idades2[i];
            }

            foreach (int item in idades2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(idades2);
        }
        static void TesteListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            ListaDeObject listadeNomes = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(20);
            listaDeIdades.Adicionar(30);
            listaDeIdades.AdicionarVarios(40, 50, 60, 70);

            listadeNomes.Adicionar("janderson");

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no Indice {i}:{idade}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            //TestaArrayDeContaCorrente();
            //TestaArrayInt();
            //Console.ReadLine();
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);
            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //lista.Adicionar(new ContaCorrente(874, 5679445));
            //Nomeando parametro

            //Buscando indice atual

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoIndice(i);//forma1

                //Possivel apenas devido a criação do Indexador
                ContaCorrente itemAtual2 = lista[i];//forma2
                Console.WriteLine("Idex =>" + itemAtual2.Agencia);
            }
            Console.ReadLine();

            //Usando metodo adicionar varios com paramns
            lista.AdicionarVarios(
                contaDoGui,
                 new ContaCorrente(874, 1234),
                 new ContaCorrente(874, 1235),
                 new ContaCorrente(874, 1236),
                 new ContaCorrente(874, 1237),
                 new ContaCorrente(874, 1238)
                );

            lista.MeuMetodo(texto: "Janderson");

            lista.EscreverListaNaTela();

            lista.Remover(contaDoGui);

            Console.WriteLine("Após remover o item");

            lista.EscreverListaNaTela();
        }
        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas3 = new ContaCorrente[]
            {
                new ContaCorrente(876,12345),
                new ContaCorrente(876,67890),
            };

            ContaCorrente[] contas = new ContaCorrente[]
             {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
             };

            ContaCorrente[] contas2 = new ContaCorrente[]
            {
                new ContaCorrente(875,5555555),
                new ContaCorrente(875,6565565),
                new ContaCorrente(875,6565656)
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

        //Outro exemplo com Paramns que recebe vários parametros
        //Paramns cria um array de inteiros e passa como argumento para a função
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }

            return acumulador;
        }

    }
}
