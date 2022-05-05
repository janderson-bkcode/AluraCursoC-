using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsCommand
{
    class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando); 
        }

        public void Processa()
        {
            foreach (IComando comandos in this.Comandos)
            {
                comandos.Executa();
            }
        }

    }
}
