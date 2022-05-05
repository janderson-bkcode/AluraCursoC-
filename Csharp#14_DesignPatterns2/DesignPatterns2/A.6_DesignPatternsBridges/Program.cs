using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBridges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMensagem mensagem = new MensagemAdministrativa("Vitor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
            Console.ReadLine();
        }
    }
}
