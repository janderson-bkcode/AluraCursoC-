using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        //atributos
        private string nome;
        private string cpf;
        private double salario;



        //propriedades
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cpf; private set => cpf = value; }

        public double Salario { get => salario; protected set => salario = value; }

        //Construtores
        public Funcionario()
        {
            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf, double salario, string nome)
        {
            this.cpf = cpf;
            this.salario = salario;
            this.nome = nome;
            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf, double salario) : this()
        {

        }


        //metodos sobres
        //public virtual double GetBonificacao()
        //{
        //    return Salario * 0.10;
        //}

        //public virtual void AumentarSalario()
        //{
        //    Salario *= 1.10;
        //}

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

    }
}
