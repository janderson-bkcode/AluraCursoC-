using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A._5_CursoDesignPatternsState
{
    public class Item
    {

        public String Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome ,double valor) 
        {
            Nome = nome;
            Valor = valor;
        }

    }
}