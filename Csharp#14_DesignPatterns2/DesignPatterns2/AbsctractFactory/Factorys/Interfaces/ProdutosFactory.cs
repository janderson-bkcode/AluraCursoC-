using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbsctractFactory.Produtos.Interfaces;


namespace AbsctractFactory.Produtos.Interfaces
{
    public interface ProdutosFactory
    {
        ICadeira criarCadeira();
        ISofa criarSofa();

    }
}