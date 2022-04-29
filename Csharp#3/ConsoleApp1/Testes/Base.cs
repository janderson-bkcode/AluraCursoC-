using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Testes
{
    public class Base
    {
        private int _numero;
        public virtual int Numero { get => _numero; set=> Numero = value; }

        public virtual void M()
        {

        }
    }
}
