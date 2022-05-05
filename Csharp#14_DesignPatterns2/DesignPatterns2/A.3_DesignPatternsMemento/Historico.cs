using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento
{
    /// <summary>
    /// Classe que representa o Histório do Contrato
    /// e guarda todos os estados de um Contrato.
    /// Precisa instanciar antes de usar o método
    /// <see cref="Contrato.SalvaEstado"/>
    /// </summary>
    internal class Historico
    {

        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        /// <summary>
        /// Método para recuperar um estado na List de estados <see cref="Historico.Estados"/>
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public Estado Pega(int indice)
        {
            return Estados[indice];
        }
    }
}
