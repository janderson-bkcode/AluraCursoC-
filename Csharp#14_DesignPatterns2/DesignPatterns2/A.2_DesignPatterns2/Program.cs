using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.2_DesignPatterns2FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new List<INota>()
            {
                new Do(),new Re(),new Mi(),new Fa(),new Fa()
            };

        }
    }
}
