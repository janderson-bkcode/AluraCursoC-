using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsCommand
{
    class FinalizaPedido : IComando
    {
        public Pedido Pedido { get; set; }

        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {Pedido.Cliente}");
            Pedido.Finaliza();
        }
    }
}
