using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns1
{   /// <summary>
    /// Classe que Define o Orçamento do cliente
    /// </summary>
    public class OrcamentoStrategyClient
    {
        public double Valor { get; set; }

        public OrcamentoStrategyClient(double valor)
        {
            Valor = valor;
        }
    }
}
