using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        //Propriedades

        public double Saldo { get; }
        public double ValorSaque { get; }

        //Construtores
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque, string mensagem) : this(mensagem)
        {

            Saldo = saldo;
            ValorSaque = valorSaque;

        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }

    }
}
