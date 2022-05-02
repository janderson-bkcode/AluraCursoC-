//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace A._4_DesignaPatternsDecorator.ExercicioFiltro
//{

//    public class FiltroMenorQue100Reais : Filtro
//    {
//        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

//        public FiltroMenorQue100Reais() : base() { }

//        public override IList<Conta> Filtra(IList<Conta> contas)
//        {
//            IList<Conta> filtrada = new List<Conta>();
//            foreach (Conta c in contas)
//            {
//                if (c.Valor < 100) filtrada.Add(c);
//            }
//            foreach (Conta c in Proximo(contas))
//            {
//                filtrada.Add(c);
//            }
//            return filtrada;
//        }
//    }

//    public class FiltroMaiorQue500MilReais : Filtro
//    {
//        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

//        public FiltroMaiorQue500MilReais() : base() { }

//        public override IList<Conta> Filtra(List<Conta> contas)
//        {
//            IList<Conta> filtrada = new List<Conta>();
//            foreach (Conta c in contas)
//            {
//                if (c.Valor > 500000) filtrada.Add(c);
//            }
//            foreach (Conta c in proximo(contas))
//            {
//                filtrada.Add(c);
//            }
//            return filtrada;
//        }
//    }

//    public class FiltroMesmoMes : Filtro
//    {
//        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

//        public FiltroMesmoMes() : base() { }

//        public override IList<Conta> Filtra(List<Conta> contas)
//        {
//            IList<Conta> filtrada = new List<Conta>();
//            foreach (Conta c in contas)
//            {
//                if (c.DataAbertura.Month == DateTime.Now.Month &&
//                  c.DataAbertura.Year == DateTime.Now.YEAR)
//                {
//                    filtrada.add(c);
//                }
//            }

//            foreach (Conta c in proximo(contas))
//            {
//                filtrada.Add(c);
//            }
//            return filtrada;
//        }
//    }
//}
