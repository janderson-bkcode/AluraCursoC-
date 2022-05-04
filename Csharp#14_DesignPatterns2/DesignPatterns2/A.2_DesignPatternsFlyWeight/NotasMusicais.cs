using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsFlyWeight
{/// <summary>
/// Classe que define a criação de objetos notas apenas uma vez
/// para que possam ser reutilizados ou seja
/// instanciará uma nota de cada, 
/// e sempre que alguém pedir uma nota, 
/// ela devolverá sempre a mesma instância.
/// Funciona como Design Pattern FlyWeight
/// </summary>
    class NotasMusicais
    {

        private static IDictionary<string, INota> notas = new Dictionary<string, INota>()
        {
            {"do",new Do() },
            {"re",new Re() },
            {"mi",new Mi() },
            {"fa",new Fa() },
            {"sol",new Sol() },
            {"la",new La() },
            {"si",new Si() }
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }


}
