
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace A32SetNoModelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Um HashSet é uma coleção que representa um conjunto de valores. Falando assim, ele se parece com uma lista. Porém, existem diferenças claras:
            1- Um conjunto não aceita duplicação de itens.
            Por outro lado, uma lista permite que o mesmo valor seja armazenado em várias posições diferentes.
            2 -Um conjunto não é uma sequência. 
            Diferente da classe List, onde adicionamos elementos ao final da coleção,
            os elementos do conjunto HashSet não são mantidos em nenhuma ordem específica.
            
            */


            //Declarando Cursos
            Curso csharpColecoes = new Curso("C# Coleções","Marcelo Oliveira");
            //... e adicionar 3 aulas a esse curso
            //Trabalhando com listas - 21 minutos;
            //Criando uma Aula - 20 Minutos
            //Modelando com Coleções -  24 minutos
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));

            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));

            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //Um aluno tem matrícula!
            //vamos criar a class Aluno com Nome e NumeroMatricula

            //Instanciando 3 alunos
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);

            csharpColecoes.Matricula(a2);

            csharpColecoes.Matricula(a3);


            //Imprimindo os Alunos Matriculados
            Console.WriteLine("Imprimindo os Alunos Matriculados");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            // Imprimir : O Aluno a1 está matriculado?
            Console.WriteLine($"O aluno a1 {a1.Nome} está Matriculado?" );
            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            //Vamos instanciar uma nova aluna (Vanessa Tonini)
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //Verificar se Toninin está matriculada
            Console.WriteLine("Tonini está matriculada?"+ csharpColecoes.EstaMatriculado(tonini));

            Console.WriteLine("A1 === Tonini");

            //São diferente ! Precisamos então sobreescrever o método Equals na classe Aluno()
            Console.WriteLine(a1.Equals(tonini));//True após override do Equals


            //Limpando Console
            Console.Clear();

            //Ja temos o metodo para saber se o aluno está matriculado
            //Agora precisamos buscar aluno por número de matrícula

            //Pergunta :"Quem é o aluno com matricula 5617?"

            Console.WriteLine("Quem é o aluno com matricula 5617?");

            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            Console.WriteLine(aluno5617);


            Console.ReadLine();

        }
    }
}
