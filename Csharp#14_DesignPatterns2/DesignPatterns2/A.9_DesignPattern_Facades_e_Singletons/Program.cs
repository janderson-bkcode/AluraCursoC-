using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    public class Program
    {
        public static TipoBoleto Tipo { get; }

        static void Main(string[] args)
        {

            //Uso do singleton
            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;


            // Uso do facade acessando metodos escondidos que geram classes
        //   EmpresaFacade facade = new EmpresaFacade();
        //   Cliente cliente = facade.BuscaCliente(cpf);

            //String cpf = /// pega cpf
            //ICliente Cliente = new ClienteDao().BuscaPorCpf(cpf);

            
            //Fatura fatura = new Fatura(cliente, valor);

            //Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            //cobranca.Emite();

            //ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            //contato.Dispara();
        }
    }
}
