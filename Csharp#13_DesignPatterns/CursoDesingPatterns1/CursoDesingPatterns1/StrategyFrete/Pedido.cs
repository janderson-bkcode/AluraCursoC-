using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1.StrategyFrete
{
    public class Pedido
    {
        public double Valor { get; }

        public Pedido(double valor)
        {
            Valor = valor;
        }
    }
}
