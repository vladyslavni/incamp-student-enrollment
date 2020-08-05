using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;

namespace InternshipTest.Institution
{
    public class University
    {
        private string name;

        private List<Student> students = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public double getAverageGrade()
        {
            int studentsCount = students.Count();
            double studentGradesSum = students.Sum(student => student.GetKnowledge().getLevel());

            return studentGradesSum / studentsCount;
        } 
    }
}
