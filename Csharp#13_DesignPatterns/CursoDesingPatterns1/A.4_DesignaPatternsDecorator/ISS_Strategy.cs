using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignaPatternsDecorator
{    /// <summary>
     /// Classe que tem como função representar o ISS,
     /// Representa o StrategyConcrete do Desing Pattern Strategy
     /// </summary>
    public class ISS_Strategy : Imposto
    {
        public ISS_Strategy(Imposto outroImposto) : base(outroImposto)
        {

        }

        public ISS_Strategy():base()
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento); 
        }

    }
}
