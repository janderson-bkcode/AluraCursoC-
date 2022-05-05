using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_DesignPatternVisitor
{
    internal class ImpressoraVisitor : IVisitor
    {

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            //Esquerda
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            //Direita
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            //Esquerda
            subtracao.Direita.Aceita(this);
            Console.Write("-");
            //Direita
            subtracao.Esquerda.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
