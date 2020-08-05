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

        public void AddInterns(University university)
        {
            interns.AddRange(university.getBestStudents());
        }

        public string GetInterns()
        {
            return string.Join(",\n", interns);
        }
    }
}