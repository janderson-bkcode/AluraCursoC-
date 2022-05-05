using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
    internal class Subtracao : IExpressao
    {
        public IExpressao Direita { get; }
        public IExpressao Esquerda { get; }


        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Direita = direita;
            this.Esquerda = esquerda;
        }



        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
