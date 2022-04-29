using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class ClassTeste
    {
        public ClassTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            teste.MetodoInterno();


            //}

        }

        public class DerivadaModificadoresTeste : ModificadoresTeste
        {
            public DerivadaModificadoresTeste()
            {
                MetodoProtegido();
                MetodoInterno();
                MetodoPublico();
            }
        }

        public class ModificadoresTeste
        {
            public void MetodoPublico()
            {
                //Visível fora da classe "ModificadoresTeste"
            }

            private void MetodoPrivado()
            {
                //Visível apenas na classe "ModificadoresTeste"
            }

            protected void MetodoProtegido()
            {
                //Visível apenas para classes filhas da ClassTeste

            }

            internal void MetodoInterno()
            {
                //Visível apenas para o projeto ByteBank.Modelos!

            }
        }


    }
}
