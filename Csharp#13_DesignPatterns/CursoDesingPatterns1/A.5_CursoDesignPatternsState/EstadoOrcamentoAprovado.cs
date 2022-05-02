using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    internal class EstadoOrcamentoAprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -=  orcamento.Valor * 0.02;
        }
    }
}
