using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    // [item][item][item][item][item]
    //                                ^
    //                                 `- _proximaPosicao


    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        public int Tamanho {get => _proximaPosicao;}


        //Usando parametro capacidadeInicial com valor opicional = 5
        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texti padrao", int numero = 5)
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

       
        //Usando Params para aceitar vários argumentos
        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            //for (int i = 0; i < itens.Length; i++)
            //{
            //    Adicionar(itens[i]);
            //}

            foreach (ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }


        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            // Quero remover o 0x01

            // [0x01] [0x02] [0x03] [0x04] [0x05] [null]
            //                       ^
            //                        ` _proximaPosicao

            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }

        public ContaCorrente GetItemNoIndice(int indice)
        {
            if (indice <0 || indice >= _proximaPosicao)
            {
                throw new ArgumentException(nameof(indice));
            }

            return _itens[indice];
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            //Dobra o tamanho do array itens caso menor que tamamhoNecessario
            int novoTamanho = _itens.Length * 2;

            //Caso informe tamanho necessário maior que o novo tamanho, iguala
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            Console.WriteLine("Aumentando capacidade da lista!");

            //Criando novo array já que não podemos aumentar capacidade do original
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];


            for(int indice = 0; indice < _itens.Length; indice++)
            {
                //Guardando ou copiando valores do array antigo noNovoArray
                novoArray[indice] = _itens[indice];
                
                
                /*
               Outras formas do acima com "Array COpy"
                 
               Variantes do Array Copy:
 
               1-  Array.Copy(_itens, novoArray, _itens.Length);


               2- Array.Copy(
                            sourceArray: _itens,
                            destinationArray: novoArray,
                            length: _itens.Length);

               3-Array.Copy(
                            sourceArray: _itens,
                            sourceIndex: 4,

                            destinationArray: novoArray,
                            destinationIndex: 2,

                            length: 3);

                  // copiando 3 itens, a partir do índice 4,
                  // em novoArray, a partir do índice 2:

                 */

                Console.WriteLine(".");
            }

             //Referência _itens que aponta para o novoArray
            _itens = novoArray;

        }

        //Indexador
        public ContaCorrente this [int indice] { get=> GetItemNoIndice(indice); }

        public ContaCorrente this[string texto] { get => null; }


    }
}
