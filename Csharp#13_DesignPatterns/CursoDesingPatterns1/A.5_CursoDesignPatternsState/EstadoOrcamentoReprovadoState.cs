using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    internal class EstadoOrcamentoReprovadoState : EstadoDeUmOrcamentoState
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebe desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já reprovado não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoOrcamentoFinalizadoState();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já reprovado");
        }
    }
}
