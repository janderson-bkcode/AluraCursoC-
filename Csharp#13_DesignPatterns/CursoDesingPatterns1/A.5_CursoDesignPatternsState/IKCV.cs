using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
           
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
                
            }
            return false;
        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
