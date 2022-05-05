using System;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    public class Cobranca
    {
        public Fatura Fatura { get; private set; }
        public TipoBoleto Boleto { get ; private set; }

        public Cobranca(TipoBoleto boleto, Fatura fatura)
        {
            this.Boleto = boleto;
            this.Fatura = fatura;
        }



        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }
}