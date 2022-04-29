using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Designer : Funcionario
    {/// <summary>
    /// Cria uma instancia da classe Designer
    /// </summary>
    /// <param name="cpf"></param>
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        
        internal protected override double GetBonificacao()
        {   //Precisa do Internal protected porque esta no mesmo projeto da class base
            return Salario * 0.17;
        }
    }
}
