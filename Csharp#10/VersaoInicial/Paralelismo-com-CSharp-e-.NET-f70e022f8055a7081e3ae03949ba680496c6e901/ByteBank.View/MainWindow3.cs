using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ByteBank.View
{        //--------------------------------------
         // 01 Usando Threads
         //---------------------------------------

         // Parte 1 do curso finalizado apenas usando criando 4 Threads na mão
    public class MainWindow3 : Window
    {
        #region Propriedades
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        #endregion

        #region Métodos
        public MainWindow3()
        {
           // InitializeComponent();

            //Criação do repositório
            r_Repositorio = new ContaClienteRepository();

            //Criação do Serviço
            r_Servico = new ContaClienteService();
        }

        // Metodo de ação do Botão
        private void BtnProcessar_Click(object sender, RoutedEventArgs e)

        {   //Obtendo todas as contas do repositório
            var contas = r_Repositorio.GetContaClientes();

            //Definindo a quantidade de Threads e divisão das contas para serem processadas,nesse caso será 4 partes de dados da lista de contas em 4 Threads 
            var ContasQuantidadePorThread = contas.Count() / 4;

            ////Divindo em duas partes os dados para ser processado em 2 Core
            //var contas_parte1 = contas.Take(contas.Count() / 2);//Take recebe um int e pega n sequencia de dados neste caso a primeira metades da lista
            //var contas_parte2 = contas.Skip(contas.Count() / 2);//Recebe um int e representa como paramentro n numeros que será pulado e guardará o que vem em diante

            var contas_parte1 = contas.Take(ContasQuantidadePorThread); // Pegando a primeira porção de dados
            var contas_parte2 = contas.Skip(ContasQuantidadePorThread).Take(ContasQuantidadePorThread); //Pula a primeira porção e pega a segunda porção de dados
            var contas_parte3 = contas.Skip(ContasQuantidadePorThread * 2).Take(ContasQuantidadePorThread);//Pula 2 vezes  e pega a terceira porção
            var contas_parte4 = contas.Skip(ContasQuantidadePorThread * 3);//Pula 3 vezes e pega o restante dos dados


            //Criação de uma lista de string vazia que armazerá o resultado com os dados da contas
            var resultado = new List<string>();

            //Chamando aqui para limpar a tela
            AtualizarView(new List<string>(), TimeSpan.Zero);

            //Armazena o momento(data) do processamento , um contador no caso
            var inicio = DateTime.Now;


            // Criando a 1º Thread de processamento

            Thread thread_parte1 = new Thread(() =>
            {
                // Para cada conta na primeira metade da lista de contas 
                foreach (var conta in contas_parte1)
                {
                    //Chamar o serviço
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);

                    //Armazenando o processamento na lista de resultado
                    resultado.Add(resultadoProcessamento);
                }
            });

            // Criando a 2º Thread de processamento
            Thread thread_parte2 = new Thread(() =>
            {
                // Para cada conta na segunda metade da lista de contas 
                foreach (var conta in contas_parte2)

                {   //Chamar o serviço com os dados e jogar no resultado de processamento
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);

                    //Armazenando o processamento na lista para ser apresentada
                    resultado.Add(resultadoProcessamento);
                }
            });


            // Criando a 3º Thread de processamento
            Thread thread_parte3 = new Thread(() =>
            {
                // Para cada conta na segunda metade da lista de contas 
                foreach (var conta in contas_parte3)

                {   //Chamar o serviço com os dados e jogar no resultado de processamento
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);

                    //Armazenando o processamento na lista para ser apresentada
                    resultado.Add(resultadoProcessamento);
                }
            });


            // Criando a 4º Thread de processamento
            Thread thread_parte4 = new Thread(() =>
            {
                // Para cada conta na segunda metade da lista de contas 
                foreach (var conta in contas_parte4)

                {   //Chamar o serviço com os dados e jogar no resultado de processamento
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);

                    //Armazenando o processamento na lista para ser apresentada
                    resultado.Add(resultadoProcessamento);
                }
            });

            // Iniciando as Threads criadas acima para serem processadas
            thread_parte1.Start();
            thread_parte2.Start();
            thread_parte3.Start();
            thread_parte4.Start();

            // Inicia o processamento e para quando chega no fim do processamento de dados das Threads
            while (thread_parte1.IsAlive || thread_parte2.IsAlive || thread_parte3.IsAlive || thread_parte4.IsAlive)
            {
                //Coloca a Thread principal para dormir(suspende) em milisegundos quando não estiver processando
                Thread.Sleep(250);
            }

            //Armazena o momento(data) de término do processamento
            var fim = DateTime.Now;

            //Chama o AtualizarViev para apresentar os dados ,a data e hora do fim e inicio do processo
            AtualizarView(resultado, fim - inicio);
        }


        private void AtualizarView(List<String> result, TimeSpan elapsedTime)
        {
            //Tempo de execução
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count} clientes em {tempoDecorrido}";

            //Atualizando a lista de resultado
           // LstResultados.ItemsSource = result;

            //Atualizando o campo que informará a quantidade de dados processados em tela
           // TxtTempo.Text = mensagem;
        }
        #endregion
    }
}
