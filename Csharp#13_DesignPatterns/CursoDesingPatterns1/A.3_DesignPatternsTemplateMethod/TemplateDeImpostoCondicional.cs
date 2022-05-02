using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod
{
    /// <summary>
    /// Classe que representa o TemplateMethod.
    /// Classes <see cref="ICPP"/> e <see cref="IKCV"/>
    /// usam como modelo e herdam seus métodos abstratos
    /// porque possuem a mesma lógica de  regra de négocio de Maxima
    /// e Mínima Taxação apenas muda a implementação e valor de taxa
    /// conforme imposto
    /// </summary>
    public abstract class TemplateDeImpostoCondicional : ImpostoStrategyInterface
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }
        
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);

       
    }
}

