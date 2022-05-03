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
        public EstadoDeUmOrcamentoState EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; }


        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EstadoOrcamentoEmAprovacaoState();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
