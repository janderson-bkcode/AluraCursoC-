using CursoDesingPatterns1.StrategyFrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando variaveis das duas Estratégias ISS e ICMS
            ImpostoStrategyInterface iss = new ISS_Strategy();
            ImpostoStrategyInterface icms = new ICMS_Strategy();
            ImpostoStrategyInterface iccc = new ICCC_Strategy();

            //Instanciando Orçamento
            OrcamentoStrategyClient orcamento = new OrcamentoStrategyClient(500.0);

            //Instanciando Context
            CalculadorDeImpostosStrategyContext calculador = new CalculadorDeImpostosStrategyContext();

            //Chamando Método Realiza Calculo 
            calculador.RealizaCalculo(orcamento,icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento,iccc);

            //Frete
            CalculadorDeFreteStrateyContext calculadorDeFrete = new CalculadorDeFreteStrateyContext();
            IFreteStrategyInterface freteExpress = new FreteExpressoStrategycs();
            IFreteStrategyInterface fretePadrao = new FretePadraoStrategy();
            Pedido pedido = new Pedido(1000);
            double valorFrete = calculadorDeFrete.GetCalculoDoFrete(pedido, freteExpress);

            Console.WriteLine(); ;
            Console.WriteLine($"Valor do frete {valorFrete}");


            Console.ReadKey();
                    
        }
    }
}
