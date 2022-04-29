using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1.StrategyFrete
{
    public interface IFreteStrategyInterface
    {
        double Calcular(Pedido pedido);
    }
}
