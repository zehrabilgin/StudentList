using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new StudentList();

            list.Add(new Student { Id = 1 , Name = "Nikolay", Surname = "Gogol",GPA= 2.50});
            list.Add(new Student { Id = 2, Name = "Fyodor", Surname = "Dostoevsky", GPA = 3.48 });
            list.Add(new Student { Id = 3, Name = "Leo", Surname = "Tolstoy", GPA = 3.45 });
            list.Add(new Student { Id = 4, Name = "Alexander", Surname = "Pushkin", GPA = 3.71 });
            list.Add(new Student { Id = 4, Name = "Ernest", Surname = "Hemingway", GPA = 3.11 });


            var highestGpas = list.GetStudentWithHighestGPA();
            highestGpas.ForEach(s => Console.WriteLine($"Soyad: {s.Surname} ve GPA: {s.GPA}"));

            var results = list.GetStudentByName("Fyodor");
            results.ForEach(s => Console.WriteLine($"{s.Surname}"));

            list.RemoveBySurname("Hemingway");

            list.Yazdır();

            var getIdByUser = list.GetStudentById(4);
            Console.WriteLine(getIdByUser.Name + getIdByUser.Surname);

            Console.ReadLine();
        }


    }
}
