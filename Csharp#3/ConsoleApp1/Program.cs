using ByteBank.Funcionarios;
using ConsoleApp1;
using ConsoleApp1.Funcionarios;
using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();



            //Funcionario carlos = new Funcionario("123465", 2000,"Carlos");

            //gerenciador.Registrar(carlos);

            //Diretor roberta = new Diretor("1234567",5000,"Roberta");

            //gerenciador.Registrar(roberta);

            //Funcionario janderson = new Diretor("987654",1500,"Janderson");
            //gerenciador.Registrar(janderson);


            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine("Bonificação: " + roberta.GetBonificacao());
            //roberta.AumentarSalario();
            //Console.WriteLine("Novo Salário:" + roberta.Salario);

            //Console.WriteLine(carlos.Nome);
            //Console.WriteLine("Bonificação: " + carlos.GetBonificacao());
            //carlos.AumentarSalario();
            //Console.WriteLine("Novo Salário:" + carlos.Salario);
            //Console.WriteLine("Total de Bonificação: " + gerenciador.GetTotalBonificacao());
            //Console.WriteLine("Total de funcionarios "+Funcionario.TotalDeFuncionarios);


            CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno  sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("121231",5000,"roberta");
            GerenteDeConta camila = new GerenteDeConta("121313231", 4000, "camila");
            Funcionario pedro = new Designer("kllk", 2500, "Pedro");

            roberta.Senha = "123";
            camila.Senha = "143";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12121";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "143");
            sistemaInterno.Logar(parceiro, "12121");







        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorB = new GerenciadorBonificacao();

            Designer pedro = new Designer("122112", 3000, "Pedro");

            Auxiliar igor = new Auxiliar("122112", 3000, "Igor");

            Diretor roberta = new Diretor("122112", 3000, "Roberta");

            GerenteDeConta camila = new GerenteDeConta("122112", 3000, "Camila");

            gerenciadorB.Registrar(pedro);

            gerenciadorB.Registrar(igor);

            gerenciadorB.Registrar(roberta);

            gerenciadorB.Registrar(camila);

            Console.WriteLine("Total de bonificação por mês" + gerenciadorB.GetTotalBonificacao());
        }
    }
}
