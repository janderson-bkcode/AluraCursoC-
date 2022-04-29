// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorSaquesnaoPermitido { get; private set; }
        public int ContadorTranferenciaNaoPermitidas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        // private readonly int _numero;


        public int Numero { get; }//somente leitura == readonly

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }



        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento \"NumeroAgencia\" deve ser maior que 0", nameof(numeroAgencia));
            }
            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento \"numeroConta\" deve ser maior que 0", nameof(numeroConta));
            }




            Agencia = numeroAgencia;
            Numero = numeroConta;


            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public bool Sacar(double valor)
        {

            if (valor <= 0)
            {
                throw new ArgumentException("Valor negativo ou inválido para o saque", nameof(valor));
            }
            if (_saldo < valor)

            {
                ContadorSaquesnaoPermitido++;
                //string msg = "Saldo Insuficiente para o saque no valor de " + valor;
                //throw new SaldoInsuficienteException(msg);
                throw new SaldoInsuficienteException(Saldo, valor, "Tentativa de saque de valor " + valor + " R$ em uma conta com saldo de " + Saldo + "R$");
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor negativo ou inválido para a Tranferência", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTranferenciaNaoPermitidas++;
                // throw;    // No stackTracer Mostra Sacar() na pilha de exceções
                // throw ex; // No stackTracer não mostra Sacar() na pilha de exceções
                //throw new Exception("Operação não realizada", ex);
                throw new OperacaoFinanceiraException("Operacao Não Realizada", ex);
            }

            contaDestino.Depositar(valor);

        }
    }
}
