using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsTemplateMethod.TesteDataMiner
{
    public class CSVDataMiner : DataMiner
    {
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
            throw new NotImplementedException();
        }

        protected override void parseData()
        {
            throw new NotImplementedException();
        }
    }
}
