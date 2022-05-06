using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    public class RoadLogisticTransport : LogisticaFactory
    {
        public override ITransport createTransport()
        {
            return new Caminhao();
        }
    }
}
