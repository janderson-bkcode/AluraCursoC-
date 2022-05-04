using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_DesignPatternsFlyWeight
{
    internal class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia,300);
            }
        }
    }
}
