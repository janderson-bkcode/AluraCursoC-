using ByteBank.Funcionarios;
using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string  Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario, string nome) : base(cpf, salario, nome)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

       
    }

   
}
