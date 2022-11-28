namespace Githubtest22.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id) //jeg har lavet en name parameter
        {
            Id = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
