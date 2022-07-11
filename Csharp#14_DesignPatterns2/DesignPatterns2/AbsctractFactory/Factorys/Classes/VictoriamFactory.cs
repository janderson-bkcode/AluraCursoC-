using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbsctractFactory.Produtos.Classes.Victoriam;

namespace AbsctractFactory.Factorys.Classes
{
    public class VictoriamFactory : ProdutosFactory
    {
        public ICadeira criarCadeira()
        {
            return new VictorianCadeira();
        }

        public ISofa criarSofa()
        {
            return new VictorianCadeira();
        }
    }
}