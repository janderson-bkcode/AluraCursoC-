using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._4_DesignaPatternsDecorator.ExercicioFiltro
{
    class Conta
    {
        public String Titular { get; private set; }

        public String Nome { get; set; }

        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public int Agencia { get; set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
    enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

}
