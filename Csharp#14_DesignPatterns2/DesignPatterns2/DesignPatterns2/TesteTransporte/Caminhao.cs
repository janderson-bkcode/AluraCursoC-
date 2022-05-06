using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    internal class Caminhao : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Dirigindo e comendo putas");
        }
    }
}
