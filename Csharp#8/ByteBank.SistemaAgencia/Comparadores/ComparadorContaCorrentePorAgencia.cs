using ByteBank.Modelos;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            //Versão clean 
           // x.Agencia.CompareTo(y.Agencia);
            return x.Agencia.CompareTo(y.Agencia);


            // Versão na mão e verbosa
            //if (x == y)
            //{
            //    return 0;
            //}
            //if (x == null)
            //{
            //    return 1;
            //}
            //if (y == null)
            //{
            //    return -1;
            //}
            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}

            //if (x.Agencia == y.Agencia)
            //{
            //    return 0;
            //}
            //return 1;
        }
    }
}
