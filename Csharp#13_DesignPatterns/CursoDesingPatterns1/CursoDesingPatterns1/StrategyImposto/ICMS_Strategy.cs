using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1
{
    /// <summary>
    /// Classe que tem como função representar o ICMS,
    /// Representa o StrategyConcrete do Desing Pattern Strategy
    /// </summary>
    public class ICMS_Strategy : ImpostoStrategyInterface
    {
        /// <summary>
        /// Método implementando da interface <see cref="ImpostoStrategyInterface"/>
        /// e retorna o imposto ICMS de 10 % sobre o valor do <paramref name="orcamento"/>
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public double Calcula(OrcamentoStrategyClient orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
