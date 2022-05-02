using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{   /// <summary>
    /// Classe que possui uma estratégia de desconto: 5% se tivermos LAPIS e CANETA na mesma compra.
    /// </summary>
    public class IDescontoHandlerPorVendaCasada : IDescontoHandler
    {
        public IDescontoHandler Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }

    public class TestaCorrente
    {
        static void Testar()
        {
            IDescontoHandler d1 = new DescontoPorCincoItensConcreteHandlers();
            IDescontoHandler d2 = new DescontoPorMaisDeQuinhentosReaisConcreteHandlers();
            IDescontoHandler d3 = new IDescontoHandlerPorVendaCasada();
            IDescontoHandler d4 = new SemDescontoConcreteHandler();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento orcamento = new Orcamento(500.0);

            double IDescontoHandler = d1.Desconta(orcamento);
            Console.WriteLine(IDescontoHandler);
        }
    }
}
