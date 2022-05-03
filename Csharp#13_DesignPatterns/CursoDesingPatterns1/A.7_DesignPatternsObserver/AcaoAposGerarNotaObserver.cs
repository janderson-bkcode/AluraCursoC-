using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._7_DesignPatternsObserver
{   /// <summary>
    /// Inteface que funciona como Design Pattern Observer
    /// </summary>
    public interface AcaoAposGerarNotaObserver
    {

        void Executa(NotaFiscal nf);
    }
}
