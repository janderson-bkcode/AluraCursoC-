using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod
{   /// <summary>
    /// Classe que Define o Orçamento do cliente
    /// </summary>
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; }


        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
