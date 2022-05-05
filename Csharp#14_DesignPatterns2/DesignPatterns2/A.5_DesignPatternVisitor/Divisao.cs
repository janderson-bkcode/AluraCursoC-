using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
     class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda / resultadoDaDireita;
        }
    }

}
