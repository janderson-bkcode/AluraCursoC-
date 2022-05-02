using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._5_CursoDesignPatternsState
{
    public class CalculadorDeDescontosBaseHandler
    {
        /// <summary>
        /// Método que cria as referências
        /// aos objetos de cada tipo de desconto e define qual o próximo da sequencia a ser chamado.
        /// Inicia pelo d1(desconto1) que é o primeiro da cadeia
        /// Funciona como Handler do Desing Pattern Chain Of Resposibility
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        public double Calcula(Orcamento orcamento)
        {
            //Versão procedural e sem o Chain responsability e de forma engessada e acoplada
            //if (orcamento.Itens.Count >5)
            //{
            //    return orcamento.Valor * 0.1;
            //}else if(orcamento.Valor > 500)
            //{
            //    return orcamento.valor * 0.07;
            //}
            //else
            //{
            //    return 0;
            //}


            IDescontoHandler descontoTipo1 = new DescontoPorCincoItensConcreteHandlers();
            IDescontoHandler descontoTipo2 = new DescontoPorMaisDeQuinhentosReaisConcreteHandlers();
            IDescontoHandler descontoTipo3 = new SemDescontoConcreteHandler();

            descontoTipo1.Proximo = descontoTipo2;
            descontoTipo2.Proximo = descontoTipo3;    
            return descontoTipo1.Desconta(orcamento);
        }


    }
}
