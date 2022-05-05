using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public void Envia()
        {

            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o Administrador {0}", nome);
        }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

    }
}
