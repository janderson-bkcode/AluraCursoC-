namespace A._9_DesignPattern_Facades_e_Singletons
{
    public class Fatura
    {
        private ICliente cliente;
        private double valor;

        public Fatura(ICliente cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }
    }
}