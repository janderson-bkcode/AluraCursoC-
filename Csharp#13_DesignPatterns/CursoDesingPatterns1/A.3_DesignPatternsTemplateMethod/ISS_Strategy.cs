using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod
{    /// <summary>
     /// Classe que tem como função representar o ISS,
     /// Representa o StrategyConcrete do Desing Pattern Strategy
     /// </summary>
    public class ISS_Strategy : ImpostoStrategyInterface
    {
        /// <summary>
        /// Método implementando da interface <see cref="ImpostoStrategyInterface"/>
        /// e retorna o imposto ISS de 6 % sobre o valor do <paramref name="orcamento"/>
        /// </summary>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06; 
        }
    }
}
