using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento
{
     class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            //Console.WriteLine(c.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            //Vendo Qual estado final do contrato
            // Console.WriteLine(c.Tipo);

            //Pegando pelo historico os estados salvos 
            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            Console.WriteLine(historico.Pega(1).Contrato.Tipo);
            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            Console.ReadLine();
        }
    }
}
