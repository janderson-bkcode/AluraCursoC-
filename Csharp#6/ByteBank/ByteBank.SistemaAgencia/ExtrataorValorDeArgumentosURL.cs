using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {

        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
            //if (url == null)
            //{
            //    throw new ArgumentNullException(nameof(url));
            //}
            //if (url == "")
            //{
            //    throw new ArgumentException("o argumento url não pode ser uma string vazio");
            //



            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);//moedaOrigem=real&moedaDestino=dolar&valor=1500

            URL = url;
        }

        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro) //moedaOrigem
        {

            nomeParametro = nomeParametro.ToUpper(); //MOEDAORIGEM
            string argumentoEmCaixaAlta = _argumentos.ToUpper();//MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR   


            string termo = nomeParametro + "="; //moedaOrigem=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);//0
                                                                  // Console.WriteLine(indiceTermo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);//reais&moedaDestino=Dolar
            int indiceEcomercial = resultado.IndexOf('&');

            if (indiceEcomercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEcomercial);

        }
    }
}
