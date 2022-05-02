using A._3_DesignPatternsTemplateMethod.ExercicioRelatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Conta> contas = new List<Conta>
            {
                new Conta("Janderson",500.0),
                new Conta("Bruno", 500.0)
            };


            RelatorioComplexo relatorioC = new RelatorioComplexo();
            relatorioC.Imprime(contas);

            Console.ReadLine();


        }
    }
}
