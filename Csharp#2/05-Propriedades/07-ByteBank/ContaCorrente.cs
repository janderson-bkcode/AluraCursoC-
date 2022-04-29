

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente titular;
        private int agencia;
        private int numero;
        private double _saldo;


      // Propriedades
      public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; } 
        }


        public int Agencia { get; set; }
        public Cliente Titular { get; set; }

        public double Numero { get; set; }

        //Metodos
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}