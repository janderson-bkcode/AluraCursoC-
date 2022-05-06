using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{
    public abstract class LogisticaFactory
    {
        public ITransport Transporte { get; private set; }

        private void planDelivery(ITransport transporte)
        {
            Transporte = transporte;
        }

        public abstract ITransport createTransport();

        public virtual void CreateAndShow()
        {
            var veiculo = this.createTransport();
            Console.WriteLine(veiculo);
        }

    }
}
