using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
    internal class Soma : IExpressao
    {
        public IExpressao Esquerda { get ; }
        public IExpressao Direita { get; }

        public Soma(IExpressao esquerda,IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

     

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda + valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
