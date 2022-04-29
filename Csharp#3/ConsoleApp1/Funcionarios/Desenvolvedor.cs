using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string cpf,double salario,string nome) : base(cpf,salario,nome)
        {

        }


        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }


    }
}
