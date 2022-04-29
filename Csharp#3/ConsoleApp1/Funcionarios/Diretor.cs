using ConsoleApp1.Funcionarios;
using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public int dep;



        //public Diretor(string nome, string cpf, double salario, int dep)
        //{
        //    base.Nome = nome;
        //    base.CPF = cpf;
        //    base.Salario = salario;
        //    this.dep = dep;
        //}
        public Diretor(string cpf, double salario, string nome) : base(cpf,salario,nome)
        {


        }

        //metodos sobrescrito
        public override double GetBonificacao()
        {
            //return Salario * 0.10;
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public bool Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }
}

