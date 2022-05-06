using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    public class RoadLogisticTransportConcreteCreator : LogisticaFactoryCreator
    {
        public override ITransportProduct createTransport()
        {
            return new CaminhaoConcreteProduct();
        }
    }
}
