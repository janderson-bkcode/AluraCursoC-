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
{
    //Versão Inicial do MainWindow.xaml
    public  class MainWindow2 : Window
    {
        #region Propriedades
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        #endregion

        #region Métodos
        public MainWindow2()
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

            //Processamento
            foreach (var conta in contas)
            {   //Para cada conta em contas => Chamar o serviço=> Consolidação das contas
                var resultadoConta = r_Servico.ConsolidarMovimentacao(conta);
                //Guarda os dados na lista de resultados
                resultado.Add(resultadoConta);
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
          //  LstResultados.ItemsSource = result;

            //Atualizando o campo que informará a quantidade de dados processados em tela
           // TxtTempo.Text = mensagem;
        }
        #endregion
    }
}
