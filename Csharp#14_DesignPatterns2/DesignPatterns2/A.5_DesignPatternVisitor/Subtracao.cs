using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
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
