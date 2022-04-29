using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    #region Classe

    /* Como ela somente armazenará extensões
       ou seja, não possuirá estado, nem será instanciada,
       a definiremos como estática static
    */

    /*
         Lembrando que em uma classe estática
         os membros também devem ser estáticos.
     */
    public static class ListExtensoes

    {
        #region Definição de Método de Extensão
        /*
         Métodos de extensão :
         - Precisar ser numa classe do tipo static;
         - Método do tipo static;
         - Colocando o this dentro do parenteses antes do tipo do paramêtro 
         que deseja estender no caso que vai poder chamar este método;
         
         */
        #endregion
        #region Métodos

        /* Método de extensão que aceita apenas List de inteiros
           indicamos que estamos estendendo o tipo List<T>
           por meio da palavra reservada this, antes do primeiro argumento.        
         */
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {

            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
        //Método de extensão Genérico que aceita vários tipos

        public static void AdicionarVarios2<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        } 
        // Método para testar lógica dos Métodos Acima
        static void Teste()
        {
            //Testando Metodo AdicionarVarios
            List<int> idades = new List<int>();
            idades.Add(50);

            ListExtensoes.AdicionarVarios(idades, 60, 30, 2, 20);
            idades.AdicionarVarios(30, 20, 20, 20);

            //Testando método AdicionarVarios2
            List<int> numeros = new List<int>();
            numeros.AdicionarVarios2<int>(1, 2, 3, 4, 5);
            numeros.AdicionarVarios2(5, 6, 7, 8, 9);//Não precisa do <int> como acima

            List<string> nomes = new List<string>();
            nomes.Add("janderson");
            nomes.AdicionarVarios2<string>("janderson", "Bernardo", "Igor", "Gabriel", "Bruno");
            nomes.AdicionarVarios2("Caio", "Thiago", "Cadu");//Não precisa do <string> como acima
        }
        #endregion

        #region Código Exercicio

        public static object[] Concatenar(this object[] a, object[] b)
        {
            var resultado = new object[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                resultado[a.Length + i] = b[i];
            }

            return resultado;

            // Não compila
            //int[] aa = new int[] { 0, 1, 2 };
            //int[] bb = new int[] { 3, 4, 5 };

            //int[] resultados = aa.Concatenar(bb);
        }
        #endregion
    }

    #region Exemplos de Método que não Funciona
    /*
     
     Caso que não funciona
        
    ** - Não é possivel uma classe genérica ter um método static de extensão

      public static class Lista<T>

      public static AdicionarVarios2(this List<string> lista,params T[] itens)
      {
          foreach (T item in itens)
          {
              lista.Add(item);
          }
      }

     */

    
    /*
     *Funciona mas tem que chamar a classe 
      ListExtensoes<int>.AdicionarVarios para funcionar
     
      public static class ListExtensoes<T>
    {
        public static void AdicionarVarios(List<T> lista, params T[] intens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            }
        }


        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4); 
     
     */
    #endregion
}
#endregion