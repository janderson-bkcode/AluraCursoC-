using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32SetNoModelo
{
    /// <summary>
    /// Representa um curso, com Nome, Instrutor e Aulas
    /// </summary>
    public class Curso
    {
        #region Atributos
        //campo privado contendo a lista de aulas
        private IList<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private string nome;
        private string instrutor;


        #endregion
        #region Propriedades
        /// <summary>
        /// Retornamos uma coleção somente leitura, isto é,
        /// ReadOnlyCollection, para proteger o campo privado aulas
        /// </summary>
        /// 
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }
        public IList<Aluno> Alunos
        {
            get => new ReadOnlyCollection<Aluno>(alunos.ToList());
        
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

           /// <summary>
        /// Obtém o tempo total do curso (somando os tempos das aulas)
        /// </summary>
        public int TempoTotal
        {
            get
            {
                ////somando o tempo total
                ////através de um acumulador
                ////===============================
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                ////somando o tempo total
                ////com o método Sum (LINQ)
                ////===============================
                //LINQ = Language Integrated Query
                //Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Encapsula a adição de uma aula à coleção de aulas do curso
        /// </summary>
        /// <param name="aula">Aula a ser adicionada</param>
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        #region Construtor
        /// <summary>
        /// Cria uma instância do Curso
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="instrutor"></param>
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }
        #endregion
        /// <summary>
        /// Método que verifica se o Aluno está matriculado no Curso
        /// </summary>
        /// <param name="aluno"></param>
        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.NumeroMatricula == numeroMatricula)
                {
                    //Console.WriteLine($"Matricula  {aluno.NumeroMatricula} encontrada pertence ao Aluno {aluno.Nome}");
                    return aluno;
                }
                
                
            }
            throw new ArgumentException($"Matricula{numeroMatricula} não consta no Curso");
        }

        /// <summary>
        /// Obtém texto para impressão de detalhes do curso
        /// </summary>
        /// <returns>Texto com detalhes do curso</returns>
        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }
    }
    #endregion
}
