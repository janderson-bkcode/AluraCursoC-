using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsObserver
{
    public class Multiplicador : AcaoAposGerarNotaObserver
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator) { this.Fator = fator; }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * this.Fator);
        }
    }

    class Teste
    {
        static void Main(String[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplicador(2));
            builder.AdicionaAcao(new Multiplicador(3));
            builder.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .Com(new ItemDaNota("item 1", 100.0))
                .Com(new ItemDaNota("item 2", 200.0))
                .Com(new ItemDaNota("item 3", 300.0))
                .ComObservacoes("entregar notaFiscal pessoalmente")
                .NaDataAtual()
                .Constroi();
        }
    }
}
