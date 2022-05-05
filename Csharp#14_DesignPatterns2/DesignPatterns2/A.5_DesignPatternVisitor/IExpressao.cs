using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
     interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
