using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1.StrategyFrete
{
    public class CalculadorDeFreteStrateyContext
    {
        public double GetCalculoDoFrete(Pedido pedido,IFreteStrategyInterface frete)
        {
            double resultado = frete.Calcular(pedido);
            return resultado;
        }
    }
}
