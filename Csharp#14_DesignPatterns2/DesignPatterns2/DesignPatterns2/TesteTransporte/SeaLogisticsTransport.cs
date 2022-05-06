using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    internal class SeaLogisticsTransport : LogisticaFactory
    {
        public override ITransport createTransport()
        {
            return new Navio();
        }

        public void dados()
        {
            Console.Write("Dados do Navio");
        }
    }
}
