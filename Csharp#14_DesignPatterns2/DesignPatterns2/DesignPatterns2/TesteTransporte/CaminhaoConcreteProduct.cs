using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    internal class CaminhaoConcreteProduct : ITransportProduct
    {
        public String Carga { get; private set; }

        public String Modelo { get; private set; }

        public CaminhaoConcreteProduct()
        {

        }
        public CaminhaoConcreteProduct(string carga, string modelo)
        {
            Carga = carga;
            Modelo = modelo;
        }

        public void deliver()
        {
            Console.WriteLine("Dirigindo e comendo putas");
        }

        public override string ToString()
        {
            return $"Carga: {Carga} Modelo : {Modelo}";
        }
    }
}
