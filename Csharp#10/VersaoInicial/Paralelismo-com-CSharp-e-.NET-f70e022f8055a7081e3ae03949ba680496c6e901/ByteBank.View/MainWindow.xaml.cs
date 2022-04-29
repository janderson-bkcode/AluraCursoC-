using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using ByteBank.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ByteBank.View
{        //--------------------------------------
         // 04 Padroes de Notificação de progresso de tarefas
         //---------------------------------------

    public partial class MainWindow : Window
    {
        #region Propriedades
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        private  CancellationTokenSource _cts;
        #endregion

        #region Métodos
        public MainWindow()
        {
            InitializeComponent();

            //Criação do repositório
            r_Repositorio = new ContaClienteRepository();

            //Criação do Serviço
            r_Servico = new ContaClienteService();
        }

        // Metodo de ação do Botão
        private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            // Após clique e durante o processamento o botão fica Indisponível
            BtnProcessar.IsEnabled = false;

            _cts = new CancellationTokenSource();

            //Obtendo todas as contas do repositório
            var contas = r_Repositorio.GetContaClientes();

            //Alimentando valor maximo da barra de progresso
            PgsProgresso.Maximum = contas.Count();

            //Chamando aqui para limpar a tela
            LimparView();

            //Armazena o momento(data) do processamento , um contador no caso
            var inicio = DateTime.Now;

            BtnCancelar.IsEnabled = true;

            //Retorna a tarefa que aguarda o fim das outras tarefas
            //Assim as demais janelas ficam disponiveis para acesso enquanto o app está executando

            var progress = new Progress<String>(str => PgsProgresso.Value++);
            //var byteBankProgress = new ByteBankProgress<String>(str => PgsProgresso.Value++);


            try
            {
                var resultado = await ConsolidarContas(contas, progress, _cts.Token);
                var fim = DateTime.Now;
                AtualizarView(resultado, fim - inicio);
            }
            catch (Exception)
            {

                TxtTempo.Text = "Operação Cancelada pelo Usuário";
            }
            finally
            {
                BtnProcessar.IsEnabled = true;
                BtnCancelar.IsEnabled= false;
            }
            
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BtnCancelar.IsEnabled = false;
            _cts.Cancel();

        }

        //Método para retornar a uma tarefa com lista de String de contas
        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas,IProgress<string> reportadorDeProgresso,CancellationToken ct)
        {
            var tasks = contas.Select(conta =>//Mapeando cada conta para uma nova tarefa
                Task.Factory.StartNew(() =>
                {
                    ct.ThrowIfCancellationRequested();
                    var resultadoConsolidacao =  r_Servico.ConsolidarMovimentacao(conta,ct);
                    //Não usaremos atualização de PgsProgresso na Thread de Trabalho
                    //PgsProgresso.Value++;

                    reportadorDeProgresso.Report(resultadoConsolidacao);

                    ct.ThrowIfCancellationRequested();
                    return resultadoConsolidacao;
                },ct)
            );
            return await Task.WhenAll(tasks);
        }

        private void LimparView()
        {
            LstResultados.ItemsSource = null;
            TxtTempo.Text = null;
            PgsProgresso.Value = 0;
        }
        private void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            //Tempo de execução
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            //Atualizando a lista de resultado
            LstResultados.ItemsSource = result;

            //Atualizando o campo que informará a quantidade de dados processados em tela
            TxtTempo.Text = mensagem;
        }
        #endregion
    }
}
