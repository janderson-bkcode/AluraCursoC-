using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{/// <summary>
/// Classe que define o Funcionario do Banco ByteBank
/// </summary>
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }

        public string CPF { get; private set; }
        
        public double Salario { get; protected set; }

        /// <summary>
        /// Cria uma instancia da classe Funcionário
        /// </summary>
        /// <param name="salario">Representa o valor  da propriedade <see cref="Salario"/> do Funcionaro</param>
        /// <param name="cpf">Representa o valor da propriedade <see cref="CPF"/></param>
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();


        internal protected abstract double GetBonificacao();

    }
}
