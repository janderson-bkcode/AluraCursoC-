using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = (Cliente)obj;   //1° forma de conversão
            Cliente outroCliente2 = obj as Cliente;//2° forma de conversão

            if (outroCliente == null)
            {   //caso receba no parametro um objeto diferente de Cliente
                //retornará false 
                return false;
            }


            return
                //Nome == outroCliente.Nome &&
                CPF == outroCliente.CPF;
                //Profissao == outroCliente2.Profissao;
                
        }
    }

}
