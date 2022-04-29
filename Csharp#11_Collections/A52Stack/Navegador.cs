using System.Collections.Generic;
using System.Linq;
using System;

namespace A52Stack
{
    internal class Navegador
    {
        private string atual = "pagina.inicial";
        private readonly Stack <string> historicoAnterior = new Stack<string> ();
        private readonly Stack <string> historicoProximo = new Stack<string> ();

        public Navegador()
        {
            System.Console.WriteLine("Pagina atual :" + atual);
        }


        internal void NavegarPara(string url)
        {
            historicoAnterior.Push (atual);
            atual = url;
            Console.WriteLine("pagina Atual "+ atual);

            if (historicoProximo.Any())
            {
                historicoProximo.Clear();
            }
            
        }

        internal void Anterior()
        {
            // se historico Anterior possui algum elemento 
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Voltei :" + atual);
            }
        }

        internal void Proximo()
        {
            // se historico proximo possui algum elemento 
            if (historicoProximo.Any()) 
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Fui atual " + atual);
            }
           
        }
    }
}