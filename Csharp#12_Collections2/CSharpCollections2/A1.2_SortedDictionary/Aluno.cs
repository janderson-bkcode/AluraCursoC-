using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A1._2_SortedDictionary
{
    public class Aluno
    {
        #region Atributos
        private string nome;
        private int numeroMatricula;
        #endregion

        #region Propriedades
        public string Nome { get => nome; set => nome = value; }
        public int NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        #endregion

        #region Construtores
        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }
        #endregion

        #region Metodos

        // Override para imprimir os dados do Objeto que é filho da classe Object
        public override string ToString()
        {
            return $"[Nome:{Nome} , Matrícula:{numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {


            Aluno outroAluno = obj as Aluno;

            if (outroAluno == null)
            {
                return false;
            }
            return this.nome.Equals(outroAluno.Nome);


        }

        //public override int GetHashCode()
        //{
        //    int hashCode = 201752758;
        //    hashCode = hashCode * -1521134295 + numeroMatricula.GetHashCode();
        //    return hashCode;
        //}
        //Implementar o GetHashCode devido o  Método Equals Acima
        //Método de dispersão e espalhamento HashTable
        public override int GetHashCode()
        {
            //Gerará um hashcode para objetos que tenham o mesmo valor na propriedade nome
            //podemos fazer com que o nosso GetHashCode devolva o hash da String nome
            return this.nome.GetHashCode();
        }
        #endregion
    }
}