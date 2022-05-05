using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal class MensagemCliente : IMensagem
    {
        private string nome;

        public MensagemCliente(string nome)
        {
            this.nome = nome;

        }

        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o cliente {0}", nome);
        }
    }
}
