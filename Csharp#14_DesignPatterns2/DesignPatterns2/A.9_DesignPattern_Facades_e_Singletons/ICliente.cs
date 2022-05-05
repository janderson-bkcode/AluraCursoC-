using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    public interface ICliente
    {
        string Nome { get; set; }

        string Endereco { get; set; }

        DateTime DataDeNascimento { get; set; }
    }
}
