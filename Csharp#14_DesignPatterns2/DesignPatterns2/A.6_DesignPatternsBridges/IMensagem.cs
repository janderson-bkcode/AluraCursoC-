using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();
        string Formata();
    }

}
