using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
