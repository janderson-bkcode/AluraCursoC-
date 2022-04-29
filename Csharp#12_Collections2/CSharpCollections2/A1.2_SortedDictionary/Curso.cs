using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._2_SortedDictionary
{
    /// <summary>
    /// Representa um curso, com Nome, Instrutor e Aulas
    /// </summary>
    public class Curso
    {
        #region Atributos
        //Implementando um dicionário de alunos

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
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

        public IDictionary<int, Aluno> DicionarioAlunos { get => dicionarioAlunos; set => dicionarioAlunos = value; }

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
            dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
        //internal Aluno BuscaMatriculado(int numero)
        //{
        //    foreach (var aluno in this.alunos)
        //    {
        //        if (aluno.NumeroMatricula == numero)
        //        {
        //            return aluno;
        //        }
        //    }
        //    throw new KeyNotFoundException("Matricula não encontrada: " + numero);
        //}
        internal Aluno BuscaMatriculado(int numeroMatricula)
        {

            // return this.dicionarioAlunos[numeroMatricula]; Não verifica matriculas inexistentes

            Aluno aluno = null;

            //Tenta buscar o numero da matricula informado,caso não exista , retorna null
            //TrygetValue função nativa para Dicionarios

            //bool dicionarioTemAluno = this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            //return aluno;

            try
            {
                bool dicionarioTemMatriculaInformada = this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

                if (dicionarioTemMatriculaInformada)
                {
                    return aluno;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Matricula {numeroMatricula} não existe no curso");
                return null;
                throw new ArgumentException($"Matricula {numeroMatricula} não existe no curso", ex);
            }
        }
        /// <summary>
        /// Método para substituir um aluno e reusar a matricula
        /// </summary>
        /// <param name="aluno"></param>
        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
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
