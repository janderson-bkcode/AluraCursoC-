using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsChainResponsibility
{
    /// <summary>
    /// Classe que implemeta a interface <see cref="IDescontoHandler"/> e define as regras de desconto para adição 5 ou mais itens
    /// ao usar o método <see cref="Orcamento.AdicionaItem(Item)"/>
    /// 
    /// </summary>
    public class DescontoPorCincoItensConcreteHandlers : IDescontoHandler
    {
        public IDescontoHandler Proximo { get ; set; } 
        /// <summary>
        /// Método que define a regra de négocio para desconto 
        /// de 5 ou mais itens adicionados
        /// Caso seja falso, retorna o próximo tipo de desconto
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
