﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsChainResponsibility.Exercicio
{
    class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }

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
