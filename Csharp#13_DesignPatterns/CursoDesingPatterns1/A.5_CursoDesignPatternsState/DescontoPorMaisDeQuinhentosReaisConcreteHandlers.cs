using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    public class DescontoPorMaisDeQuinhentosReaisConcreteHandlers : IDescontoHandler
    {
        public IDescontoHandler Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconta(orcamento);
        }
        
    }
}
