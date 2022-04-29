using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Teste
    {

        private readonly string _argumentos;
        public string URL { get; }

        public Teste(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("argumento url nulo", nameof(url));

            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }


        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoCaixaBaixa = _argumentos.ToUpper();


            string termo = nomeParametro + "=";
            int indiceTermo = argumentoCaixaBaixa.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEcomercial = resultado.IndexOf('&');

            if (indiceEcomercial ==1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEcomercial);
        }
    }
}
