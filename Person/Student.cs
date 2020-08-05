namespace InternshipTest.Person
{
    public class Student
    {
        private string name;
        private Knowledge knowledge;

        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }

        public Knowledge GetKnowledge()
        {
            return knowledge;
        }

        public override string ToString()
        {
            return name;
        }
    }
}