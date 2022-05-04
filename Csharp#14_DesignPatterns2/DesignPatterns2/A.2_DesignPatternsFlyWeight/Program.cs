using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsFlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
            Console.ReadLine();
        }
    }
}
