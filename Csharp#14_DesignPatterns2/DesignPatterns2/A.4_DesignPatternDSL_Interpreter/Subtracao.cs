using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignPatternDSL_Interpreter
{
    internal class Subtracao : IExpressao
    {
        private IExpressao direita;
        private IExpressao esquerda;

        public Subtracao(IExpressao esquerda , IExpressao direita)
        {
            this.direita = direita;
            this.esquerda = esquerda;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
