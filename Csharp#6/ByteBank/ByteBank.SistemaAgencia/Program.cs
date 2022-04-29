using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando StartWith , EndsWith , Contains
            string urlTeste = "https://www.bitebank.com/cambio?";
            int indiceByteBank = urlTeste.IndexOf("https://www.bitebank.com");
            Console.WriteLine(indiceByteBank >= 0);//true

            Console.WriteLine(urlTeste.StartsWith("https://www.bitebank.com")); //true
            Console.WriteLine(urlTeste.EndsWith("cambio?"));//true
            Console.WriteLine(urlTeste.Contains("ByteBank"));//false
            Console.ReadLine();

            //-------------------
            string urlParametros = "http://www.bitebank.com/cambio?moedaOrigem=reais&moedaDestino=Dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratoDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = "valor de MoedaDestino: " + extratoDeValores.GetValor("moedaDestino");
            Console.WriteLine(valor);

            string urlParametros2 = "http://www.bitebank.com/cambio?moedaOrigem=reais&moedaDestino=Dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratoDeValores2 = new ExtratorValorDeArgumentosURL(urlParametros);
            string valorMoedaOrigem = "valor de MoedaOrigem: " + extratoDeValores.GetValor("moedaOrigem");
            Console.WriteLine(valorMoedaOrigem);
            Console.WriteLine(extratoDeValores.GetValor("VALOR"));
            Console.ReadLine();




            //Parte 1 Substring
            string url = "pagina?argumentos";
            url.Substring(6);//?argumentos
            Console.WriteLine(url);
            Console.WriteLine(url.Substring(6));//?argumentos
            Console.ReadLine();

            //Parte 2 IndexOF
            int indiceInterrogacao = url.IndexOf('?');//6
            string argumentos = url.Substring(indiceInterrogacao + 1);

            Console.WriteLine(indiceInterrogacao);//6
            Console.WriteLine(url.Substring(indiceInterrogacao));// ?argumentos
            Console.WriteLine(argumentos);// argumentos
            Console.ReadLine();

            // IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "janderson";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();

            // IndexOF recebendo String
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);//17

            Console.WriteLine(palavra);
            Console.WriteLine("Tamanho da String: " + nomeArgumento.Length);//12
            Console.WriteLine(palavra.Substring(indice)); //moedaDestino=dolar
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));//dolar
            Console.ReadLine();



            //Remove Teste
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf("&");
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            Console.WriteLine(valor);
            Console.WriteLine(valorMoedaOrigem);
            Console.ReadLine();

            //Testando replace
            string mensagemOrigem = "janderson";
            string termoBusca = "JA";

            termoBusca = termoBusca.Replace('J', 'j');
            Console.WriteLine(termoBusca);
            termoBusca = termoBusca.Replace('A', 'a');
            Console.WriteLine(termoBusca);
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            //Testando ToLower
            mensagemOrigem = mensagemOrigem.ToLower();
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            //REGEX

            string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //Quantificadores
            string padraoQuantificador = "[0-9]{4}[-][0-9]{4}";
            string padraoQuantificador2 = "[0-9]{4,5}[-][0-9]{4}";
            string padraoQuantificador3 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padraoQuantificador4 = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padraoQuantificador5 = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Guilherme , me ligue em 4784-4546 ";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Match resultado = Regex.Match(textoDeTeste, padraoQuantificador);
            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            // Classe Object parte 05

            object conta = new ContaCorrente(1224, 321);
            Console.WriteLine(conta);
            Console.ReadLine();

            //Testando Equals

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "carlos";
            carlos_1.Profissao = "DEV";
            carlos_1.CPF = "1234";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "carlos";
            carlos_2.CPF = "1234";
            carlos_2.Profissao = "DEV";

            //if (carlos_1.Equals(conta)) => retorna exception NUll reference
            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais"); // Printa este
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }

            Console.ReadLine();

        }

    }

}
