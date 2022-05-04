using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento
{
    internal class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}
