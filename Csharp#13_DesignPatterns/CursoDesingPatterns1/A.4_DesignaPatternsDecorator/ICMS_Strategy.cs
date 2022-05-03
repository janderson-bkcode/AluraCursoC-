using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignaPatternsDecorator
{
    /// <summary>
    /// Classe que tem como função representar o ICMS,
    /// Representa o StrategyConcrete do Desing Pattern Strategy
    /// </summary>
    public class ICMS_Strategy : Imposto
    {
        public ICMS_Strategy(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICMS_Strategy():base()
        {

        }

        /// <summary>
        /// Método que usa o Decorator para calcular o imposto + o outro imposto
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
