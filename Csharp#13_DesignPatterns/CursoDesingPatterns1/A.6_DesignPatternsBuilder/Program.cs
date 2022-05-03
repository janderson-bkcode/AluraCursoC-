using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            //Para usar esses pontos os métodos tem que retornar
            //NotaFiscalBuilder
            //Fluent interface ou  Method chaining é este conceito 
            //de chamadas de métodos sequencias através do "."
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23456.789/1000-12")
                .Com(new ItemDaNota("Item1", 200.0))
                .Com(new ItemDaNota("Item2", 300.0))
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.RazaoSocial);

            Console.ReadLine();




        }
    }
}
