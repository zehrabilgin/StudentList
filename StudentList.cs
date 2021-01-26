using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class StudentList
    {
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetStudentByName(string name)
        {
            return students.Where(s => s.Name.Contains(name)).ToList();
        }

        public void Yazdır()
        {
            students.ForEach(i => Console.WriteLine(i.Name));
        }

        public void RemoveBySurname(string surname)
        {
            students.Remove(students.FirstOrDefault(s => s.Surname.Equals(surname)));
        }

        public List<Student> GetStudentWithHighestGPA()
        {
            return students.Where(x => x.GPA == students.Max(y => y.GPA)).ToList();
        }


    }
}
