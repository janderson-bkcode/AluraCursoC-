using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod.TesteDataMiner
{
    public class PDFDataMiner : DataMiner

    {
        public String Extensao { get; set; }

        public String Nome { get; set; }

        public Path Caminho { get; set; }

        protected override void closeFile(Path path)
        {
            throw new NotImplementedException();
        }

   
        protected override void extractData(String file)
        {
            throw new NotImplementedException();
        }

        protected override void openFile(Path path)
        {
            Caminho = path;
        }

        protected override void parseData()
        {
            throw new NotImplementedException();
        }

        //Método sobrescrito opcionalmente
        protected override void analyze()
        {
            Console.WriteLine("Análise");
        }

    }
}
