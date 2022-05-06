using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    internal class NavioConcrete : ITransportProduct
    {
        public String Carga { get; private set; }

        public String Modelo { get; private set; }
        
        public void deliver()
        {
            Console.WriteLine("Navegando");
        }

        public NavioConcrete()
        {

        }

        public NavioConcrete(String carga, String modelo)
        {
            this.Carga = carga;
            this.Modelo = modelo;

        }

        public override string ToString()
        {
            return $"Carga: {Carga} Modelo : {Modelo}";
        }
    }
}
