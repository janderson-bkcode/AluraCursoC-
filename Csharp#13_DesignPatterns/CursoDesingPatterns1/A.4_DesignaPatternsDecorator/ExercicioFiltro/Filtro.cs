/*
 
Ao identificar contas que possam ser fraudulentas, 
um banco possui uma série de filtros que devem ser aplicados sobre 
uma lista de contas.

*Contas com saldo menor que 100 reais ou
*Contas com saldo maior do que 500 mil reais, ou
*Contas com data de abertura no mês corrente Todas essas são geralmente 
selecionadas para uma análise mais detalhada.

Usando Decorators, implemente esse conjunto de filtros 
e faça com que, ao receber uma lista, o decorator devolva 
uma nova lista com as contas que atendam a pelo menos um dos critérios acima. 
Isto é, queremos que o Filtro tenha pelo menos o método de filtragem de contas:
 
 */

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A._4_DesignaPatternsDecorator.ExercicioFiltro
//{
//    public abstract class Filtro
//    {
//        protected Filtro OutroFiltro { get; private set; }

//        public Filtro(Filtro outroFiltro)
//        {
//            this.OutroFiltro = outroFiltro;
//        }

//        public Filtro() { }

//        public abstract IList<Conta> Filtra(IList<Conta> contas);

//        protected IList<Conta> Proximo(IList<Conta> contas)
//        {
//            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
//            else return new List<Conta>();
//        }
//    }
//}
//}
