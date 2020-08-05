using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;

        private List<Student> interns = new List<Student>();
        
        public Internship(string name)
        {
            this.name = name;      
        }

        public void AddIntern(Student student, University university)
        {
            int studentGrade = student.GetKnowledge().getLevel();
            double avarageGrade = university.getAverageGrade();

            if (studentGrade >= avarageGrade) {
                interns.Add(student);
            }
        }

        public string GetInterns()
        {
            return string.Join(",\n", interns);
        }
    }
}