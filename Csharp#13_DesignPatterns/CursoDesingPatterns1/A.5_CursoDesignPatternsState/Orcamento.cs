using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{   /// <summary>
    /// Classe que Define o Orçamento do cliente
    /// </summary>
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; }


        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
