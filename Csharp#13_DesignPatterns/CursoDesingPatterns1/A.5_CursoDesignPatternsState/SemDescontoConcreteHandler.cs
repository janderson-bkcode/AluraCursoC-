using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    class SemDescontoConcreteHandler : IDescontoHandler
    {
        public IDescontoHandler Proximo { get ; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
