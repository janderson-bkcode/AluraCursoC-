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
         // 02 Usando Tasks
         //---------------------------------------


    public partial class MainWindow4 : Window
    {
        #region Propriedades
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        #endregion

        #region Métodos
        public MainWindow4()
        {
            //InitializeComponent();

            //Criação do repositório
            r_Repositorio = new ContaClienteRepository();

            //Criação do Serviço
            r_Servico = new ContaClienteService();
        }

        // Metodo de ação do Botão
        private void BtnProcessar_Click(object sender, RoutedEventArgs e)

        {   //Obtendo todas as contas do repositório
            var contas = r_Repositorio.GetContaClientes();

            //Criação de uma lista de string vazia que armazerá o resultado com os dados da contas
            var resultado = new List<string>();

            //Chamando aqui para limpar a tela
            AtualizarView(new List<string>(), TimeSpan.Zero);

            //Armazena o momento(data) do processamento , um contador no caso
            var inicio = DateTime.Now;


            //--------------------------------------
            // 02 Criando e Executando Tasks
            //---------------------------------------


            //** Transformando lista de contas em listas de tarefas usando Select Linq para Mapeamento de conta para tarefa

            var contasTarefas = contas.Select(conta =>
            {
                //Factory usa o TaskSheduler com default e que delega as tarefas para as Threads, responsável pelo gerencimamento automatico de quantidade de Threads que vai usar
                //Usando Factory que constroi a tarefa e divide automaticamente o trabalho entre Threads sem precisar criar Threads conforme o arquivo MainWindow3.cs
                return Task.Factory.StartNew(() =>
                {
                    //Chama o servico para pegar os dados e consolidar a conta
                    var resultadoConta = r_Servico.ConsolidarMovimentacao(conta);
                    //Joga numa lista de resultado
                    resultado.Add(resultadoConta);
                });

            }).ToArray();//Forçando a execução da Query 

            //Verfifica e e aguarda /não faz nada até todas as tarefas acima terminarem , trava a thread Principal
            // Linha que fica no lugar do IsAlive que está no Arquivo MainWindow3.cs

            /*Task.WaitAll(contasTarefas);*/

            //--------------------------------------
            // 04 Mantendo a interface gráfica ativa
            //---------------------------------------

            //código recém criado será executado na Thread da interface gráfica
            var taskSchedulerUI = TaskScheduler.FromCurrentSynchronizationContext();
            // Após clique e durante o processamento o botão fica Indisponível
           
            //** BtnProcessar.IsEnabled = false;

            //Retorna a tarefa que aguardar fim das outras tarefas
            //Assim as demais janelas ficam disponiveis para acesso enquanto o app está executando
            Task.WhenAll(contasTarefas)
                .ContinueWith(task/*Task que aguarda as demais*/ =>
                // ContinueWith é o método que permite encadear a execução de uma tarefa em outra
                {
                    //Armazena o momento(data) de término do processamento
                    var fim = DateTime.Now;

                    //Chama o AtualizarView para apresentar os dados ,a data e hora do fim e inicio do processo
                    AtualizarView(resultado, fim - inicio);

                    /*
                     Feito isso abaixo, a tarefa só será executada após todas as outras, 
                     como determinamos, porém, de acordo com o TaskScheduler da interface gráfica              
                     Colocando o taskShedulerUI como paramêtro para evitar uma exceçao InvalidOperationExceptio
                     que gera erro quando um thread acessa a thread da interface gráfica*/
                }, taskSchedulerUI).ContinueWith(task =>
                {
                    // No fim do processamento o botão fica disponível
                  //**  BtnProcessar.IsEnabled = true;
                }, taskSchedulerUI);
        }

        private void AtualizarView(List<String> result, TimeSpan elapsedTime)
        {
            //Tempo de execução
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count} clientes em {tempoDecorrido}";

            //Atualizando a lista de resultado
          //**  LstResultados.ItemsSource = result;

            //Atualizando o campo que informará a quantidade de dados processados em tela
           //*   TxtTempo.Text = mensagem;
        }
        #endregion
    }
}
