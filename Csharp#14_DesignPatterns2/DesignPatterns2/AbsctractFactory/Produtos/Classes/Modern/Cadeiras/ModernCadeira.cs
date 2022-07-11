using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbsctractFactory.Produtos.Interfaces;
namespace AbsctractFactory.Produtos.Classes.Modern.Cadeiras
{
    public class ModernCadeira : ICadeira
    {
        public static void haslegs()
        {
            System.Console.WriteLine("Tem pernas");
        }

        public static void sitOn()
        {
            System.Console.WriteLine("Sentar");
        }
    }
}