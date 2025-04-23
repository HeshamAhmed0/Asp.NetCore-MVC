namespace Demo.Models
{
    public class StudentList
    {
        List<Student> Students = new List<Student>();
        public StudentList()
        {
            Students.Add(new Student { Id = 10, Name = "Hesham", Addres = "Elmhala", Img = "1.jpg" });
            Students.Add(new Student{Id=20,Name="hassan",Addres="Elmhala",Img= "2.jpeg" });
            Students.Add(new Student{Id=30,Name="ali",Addres="Elmhala",Img= "1.jpg" });
        }
        public Student GetById(int id)
        {
            return Students.FirstOrDefault(S => S.Id==id);
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
