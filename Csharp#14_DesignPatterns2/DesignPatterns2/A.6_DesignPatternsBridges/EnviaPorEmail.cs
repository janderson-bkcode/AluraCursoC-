using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado a mensagem por Email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
