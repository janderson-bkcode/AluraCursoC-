using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignaPatternsDecorator
{   /// <summary>
    /// Inteface que será implementada pelos descontos.
    /// Contem um único método e uma propriedade que definará o Proximo desconto a ser chamado caso não atenda o tipo
    /// de requisição ou regra.
    /// Funciona como Handler do Design Pattern Chain of Responsability
    /// </summary>
    public interface IDescontoHandler
    {   
        double Desconta(Orcamento orcamento);
        IDescontoHandler Proximo { get; set; }
    }
}
