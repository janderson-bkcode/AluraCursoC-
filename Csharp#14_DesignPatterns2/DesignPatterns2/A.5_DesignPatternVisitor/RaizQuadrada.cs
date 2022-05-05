using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Implemente uma expressão que calcula a raíz quadrada do número. 
 Para calcular, basta usar o método Math.Sqrt().
 Uma raiz quadrada calcula o valor em cima de uma expressão.
 Cole seu código aqui.
 */
namespace A._5_DesignPatternVisitor
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e)
        {
            this.expressao = e;
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }


    }
}
