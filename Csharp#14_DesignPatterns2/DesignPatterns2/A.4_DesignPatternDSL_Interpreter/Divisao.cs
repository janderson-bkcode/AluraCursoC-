using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignPatternDSL_Interpreter
{
    public class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda / resultadoDaDireita;
        }
    }

}
