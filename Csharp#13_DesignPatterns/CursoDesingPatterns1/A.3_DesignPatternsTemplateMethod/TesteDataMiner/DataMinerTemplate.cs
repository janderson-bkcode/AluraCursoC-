using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod.TesteDataMiner
{
    public abstract class DataMiner
    {

        public String File { get; set; }
        public virtual void mine(Path path)
        {
            openFile(path);
            extractData(File);
            parseData();
            analyze();
            sendReport();
            closeFile(path);
        }
        protected abstract void openFile(Path path);
        protected abstract void extractData(String file);
        protected abstract void parseData();

        protected virtual void analyze()
        {
            Console.WriteLine("Análise");
        }
        protected virtual void sendReport()
        {
            Console.WriteLine("Reportando Analise");
        }
        protected abstract void closeFile(Path path);

    }
}
