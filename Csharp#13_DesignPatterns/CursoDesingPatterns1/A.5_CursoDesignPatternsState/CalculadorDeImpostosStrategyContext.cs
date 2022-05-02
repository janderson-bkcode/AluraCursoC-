using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    /// <summary>
    ///  Classe que representa o Context do Design Pattern Strategy
    /// Sua funçao é receber refêrencias da Interface <see cref="Imposto"/>
    /// e <see cref="Orcamento"/>
    /// </summary>
    public class CalculadorDeImpostosStrategyContext
    {
        /// <summary>
        /// Método Padrão que recebe os parametros de orçamento e imposto
        /// Chama o método "Calcula" que é implementando por uma classe que representa um tipo 
        /// específico de imposto o qual implementa a interface
        /// <see cref="Imposto"/>( Polimorfismo)
        /// </summary>
        /// <param name="orcamento"></param>
        /// <param name="imposto"></param>
        /// 


        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }

    }
}
