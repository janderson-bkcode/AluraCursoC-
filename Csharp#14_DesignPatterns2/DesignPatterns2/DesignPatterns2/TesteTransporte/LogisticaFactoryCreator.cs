using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.TesteTransporte
{   /// <summary>
    /// Classe que funciona como Design Pattern Factory 
    /// </summary>
    public abstract class LogisticaFactoryCreator
    {
        public ITransportProduct Transporte { get; private set; }

        private void planDelivery(ITransportProduct transporte)
        {
            Transporte = transporte;
        }

        //Método para instanciar objetos
        public abstract ITransportProduct createTransport();

        public virtual void CreateAndShow()
        {
            //Mostrando dados do veículo
            var veiculo = this.createTransport();
            Console.WriteLine(veiculo);
        }

    }
}
