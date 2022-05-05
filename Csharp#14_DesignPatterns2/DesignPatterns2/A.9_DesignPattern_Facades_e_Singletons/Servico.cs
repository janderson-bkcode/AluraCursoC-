using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    public class Servico
    {
        public Servico() { }

        // outros metodos aqui
    }

    public class ServicoSingleton
    {
        private static Servico instancia = new Servico();

        public Servico Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
