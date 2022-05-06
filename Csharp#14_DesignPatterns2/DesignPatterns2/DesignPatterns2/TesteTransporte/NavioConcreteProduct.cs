using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    internal class NavioConcreteProduct : ITransportProduct
    {
        public String Carga { get; private set; }

        public String Modelo { get; private set; }
        
        public void deliver()
        {
            Console.WriteLine("Navegando");
        }

        public NavioConcreteProduct()
        {

        }

        public NavioConcreteProduct(String carga, String modelo)
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
