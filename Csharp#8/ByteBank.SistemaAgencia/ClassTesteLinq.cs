using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ClassTesteLinq
    {



    }

    public class Genero
    {
        public int Id { get; set; }
        public string nome { get; set; }
    }
    public class Musica
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }

        public int AutorId { get; set; }
        public int AlbumID { get; set; }


    }

    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }

    public class Album
    {
        public int id { get; set; }
        public string nome { get; set; }

        public int AutorId { get; set; }


    }

    public class Colecao
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int MusicaId { get; set; }

        public int GeneroId { get; set; }

        public int AutorId { get; set; }

        public int AlbumId { get; set; }

    }

    public class Student
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }

        public int ID { get; set; }

        public List<int> ExamScores { get; set; }

        public Student()
        {

        }
        public Student(string FirstName, string LastName, int Id, List<int> ExamScores)
        {
            this.FirstName = FirstName;
            this.lastName = LastName;
            this.ID = Id;
            this.ExamScores = ExamScores;
        }
        public static List<Student> students = new List<Student>()
        {
            new Student(
                    FirstName: "Janderson",
                    LastName: "Barbosa",
                    Id: 120,
                    ExamScores: new List<int>() { 10, 10, 10, 10 }
                    ),
            new Student(
                FirstName:"Nicolas",
                LastName : "Silva",
                Id: 121,
                ExamScores: new List<int>{9,9,9,9}
                ),
            new Student(
                FirstName:"Thiago",
                LastName:"JJ",
                Id:122,
                ExamScores: new List<int>{8,8,8,8}
                )
        };

        public void QueryHighScores(int exam, int score)
        {
            var highScores =
                from student in students
                where student.ExamScores[exam] > score
                select new
                {
                    Name = student.FirstName,
                    Score = student.ExamScores[exam]
                };
            foreach (var highScore in highScores)
            {
                Console.WriteLine($"{highScore.Name,-15}{highScore.Score}");
            }
        }

    }

    enum GradeLevel
    {
        FirstYear = 1,
        SecondYear,
        ThirdYear,
        FourthYear,
    };


}
