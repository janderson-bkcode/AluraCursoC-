using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1.StrategyFrete
{
    public class FretePadraoStrategy : IFreteStrategyInterface
    {
        public double Calcular(Pedido pedido)
        {
            return pedido.Valor * 0.1;
        }
    }
}
