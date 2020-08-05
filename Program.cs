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
            var student1 = new Student("Bob");
            var student2 = new Student("Martin");
            var student3 = new Student("Alex");

            student1.SetKnowledge(new Knowledge(1));
            student2.SetKnowledge(new Knowledge(5));
            student3.SetKnowledge(new Knowledge(4));

            University university = new University("CH.U.I.");
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);

            Internship internship = new Internship("Interlink");
            internship.AddIntern(student1, university);
            internship.AddIntern(student2, university);
            internship.AddIntern(student3, university);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetInterns());
        }
    }
}