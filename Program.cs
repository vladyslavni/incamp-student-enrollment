using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Bob", new Knowledge(1));
            var student2 = new Student("Martin", new Knowledge(5));
            var student3 = new Student("Alex", new Knowledge(4));

            University university = new University("CH.U.I.");
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);

            Internship internship = new Internship("Interlink");
            internship.AddInterns(university);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetInterns());
        }
    }
}