using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Aplicação do state e descontos
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();

            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();

            //reforma.AplicaDescontoExtra();

            Console.ReadLine();
        }
    }
}
