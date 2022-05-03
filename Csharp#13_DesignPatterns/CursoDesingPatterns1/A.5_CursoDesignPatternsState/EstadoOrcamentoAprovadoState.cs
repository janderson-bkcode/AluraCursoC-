using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    internal class EstadoOrcamentoAprovadoState : EstadoDeUmOrcamentoState
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -=  orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de Aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoOrcamentoFinalizadoState();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento esta em aprovado , não pode ser reprovado");
        }
    }
}
