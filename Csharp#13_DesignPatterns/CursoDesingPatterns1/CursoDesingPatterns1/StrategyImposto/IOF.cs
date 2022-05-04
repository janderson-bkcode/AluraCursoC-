using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1.StrategyImposto
{
    public class IOF : ImpostoStrategyInterface
    {
        public double Calcula(OrcamentoStrategyClient orcamento)
        {
            return orcamento.Valor * 0.0082;
        }
    }
}
