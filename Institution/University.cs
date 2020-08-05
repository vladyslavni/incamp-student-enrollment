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

        public List<Student> getBestStudents() 
        {
            double averageGrade = getAverageGrade();
            
            return students.FindAll(student => student.GetKnowledge().getLevel() >= averageGrade);
        }
        
        private double getAverageGrade()
        {
            int studentsCount = students.Count();
            double studentGradesSum = students.Sum(student => student.GetKnowledge().getLevel());

            return studentGradesSum / studentsCount;
        } 
    }
}
