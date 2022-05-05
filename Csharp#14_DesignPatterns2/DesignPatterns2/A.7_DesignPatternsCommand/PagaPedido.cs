using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsCommand
{
    class PagaPedido : IComando
    {
        public Pedido Pedido { get; set; }

        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Pagando o pedido do cliente {Pedido.Cliente}");
            Pedido.Paga();
        }
    }
}
