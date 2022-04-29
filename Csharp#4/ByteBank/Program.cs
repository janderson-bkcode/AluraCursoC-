using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CarregarContas();
                TestaInnerException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch no método Main\n");
            }

            Console.WriteLine("Execução Finalizada.Tecle enter para sair\n");
            Console.ReadLine();
        
        }

        public void testeUsing()
        {
            string manyLines = @"This is line one
            This is line two
            Here is line three
            The penultimate line is line four
            This is the final, fifth line.";

            using (var reader = new StringReader(manyLines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }
        }
        private static void CarregarContas()
        {

            //-----------------------Forma1-----------------------------------

            //Implementar Inteface IDisposable na classe LeitorDeArquivo
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {

                leitor.LerProximaLinha();
            }



            //-----------------------Forma2-----------------------------------

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.Fechar();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do Tipo IoException capturada e tratada");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }

            //}

        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(150, 150);
                ContaCorrente conta2 = new ContaCorrente(485, 4456478);

                //conta.Depositar(50);
                //Console.WriteLine(conta.Saldo);
                //conta.Sacar(4000);
                conta2.Depositar(300);
                conta2.Transferir(2200, conta);
                Console.WriteLine("Novo saldo de conta1" + conta.Saldo);

                Metodo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine("Argumento com Problema " + ex.ParamName);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException e)

            {
                Console.WriteLine("Referênia Nula");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel divisão por 0");
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Seu saldo: " + ex.Saldo);
                Console.WriteLine("Valor para Saque: " + ex.ValorSaque);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo saldo insuficiente");
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine(" Informaçãoe da INNER EXCEPTION(exceção interna)");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        static void Metodo()
        {

            TestaDivisao(0);


        }

        static void TestaDivisao(int divisor)
        {

            //try
            //{
            //    int resultado = Dividir(10, divisor);
            //    Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);



            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Não é possivel divisão por 0");
            //}


            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                //ContaCorrente conta = null;
                //  Console.WriteLine(conta.Saldo);
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor =" + divisor);
                throw;

                Console.WriteLine("Depois do throw"); // não vai ser compilado por estar depois do throw
            }
        }
    }
}
