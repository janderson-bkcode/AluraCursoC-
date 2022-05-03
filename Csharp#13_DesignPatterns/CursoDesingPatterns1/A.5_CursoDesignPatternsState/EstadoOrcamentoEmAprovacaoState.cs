using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    internal class EstadoOrcamentoEmAprovacaoState : EstadoDeUmOrcamentoState
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);

          

        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoOrcamentoAprovadoState();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoOrcamentoReprovadoState();
        }

        public void Finaliza (Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não pode ir para estado finalizado diretamente");
        }
    }
}
