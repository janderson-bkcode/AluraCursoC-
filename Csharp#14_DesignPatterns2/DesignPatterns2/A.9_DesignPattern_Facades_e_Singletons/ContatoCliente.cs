using System;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    public class ContatoCliente
    {
        private ICliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(ICliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }
}