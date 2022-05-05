
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignPatternDSL_Interpreter
{
    internal class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}
