﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string cpf, double salario, string nome) : base(cpf,salario,nome)
        {

        }



        //metodos sobrescrito e obrigatórios conforme classe metodos asbtratos
        public override double GetBonificacao()
        {
            //return Salario * 0.10;
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.17;
        }
    }
}
