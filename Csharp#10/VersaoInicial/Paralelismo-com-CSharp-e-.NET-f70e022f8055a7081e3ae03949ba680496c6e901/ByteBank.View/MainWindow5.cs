using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ByteBank.View
{        //--------------------------------------
         // 03 Usando o AsyncAwait
         //---------------------------------------

    public partial class MainWindow5 : Window
    {
        #region Propriedades
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        #endregion

        #region Métodos
        public MainWindow5()
        {
           // InitializeComponent();

            //Criação do repositório
            r_Repositorio = new ContaClienteRepository();

            //Criação do Serviço
            r_Servico = new ContaClienteService();
        }

        // Metodo de ação do Botão
        private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            // Após clique e durante o processamento o botão fica Indisponível
            //  BtnProcessar.IsEnabled = false;


            //Obtendo todas as contas do repositório
            var contas = r_Repositorio.GetContaClientes();


            //Chamando aqui para limpar a tela
            AtualizarView(new List<string>(), TimeSpan.Zero);

            //Armazena o momento(data) do processamento , um contador no caso
            var inicio = DateTime.Now;


            //Retorna a tarefa que aguarda o fim das outras tarefas
            //Assim as demais janelas ficam disponiveis para acesso enquanto o app está executando
            var resultado = await ConsolidarContas(contas);
            var fim = DateTime.Now;
            AtualizarView(resultado, fim - inicio);
           // BtnProcessar.IsEnabled = true;
        }

        //Método para retornar a uma tarefa com lista de String de contas
        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas)
        {
            //** Transformando lista de contas em listas de tarefas usando Select Linq para Mapeamento de conta para tarefa
            var tasks = contas.Select(conta =>//Mapeando cada conta para uma nova tarefa
                Task.Factory.StartNew(() => r_Servico.ConsolidarMovimentacao(conta)));
            return await Task.WhenAll(tasks);
        }
        private void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            //Tempo de execução
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            //Atualizando a lista de resultado
           // LstResultados.ItemsSource = result;

            //Atualizando o campo que informará a quantidade de dados processados em tela
           // TxtTempo.Text = mensagem;
        }
        #endregion
    }
}
