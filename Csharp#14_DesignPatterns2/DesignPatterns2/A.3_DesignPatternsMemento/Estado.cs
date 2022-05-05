using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento
{
    /// <summary>
    /// Classe que guarda o estado do contrato
    /// Para caso precise voltar um estado ou 
    /// desfazer uma operação
    /// Usado como paramentro do método <see cref="Historico.Adiciona(Estado)"/>
    /// </summary>
    internal class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}
