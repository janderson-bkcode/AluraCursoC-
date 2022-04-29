using ByteBank.Funcionarios;
using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {

        public GerenteDeConta(string cpf, double salario, string nome) : base(cpf, salario, nome)
        {

        }
        //metodos sobrescrito
        public override double GetBonificacao()
        {
            //return Salario * 0.10;
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.25;
        }

        public bool Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }
}

