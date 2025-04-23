namespace Assignment2.Models
{
    public class StudentData
    {
        List<Student> students=new List<Student>();
        public StudentData()
        {
            students.Add(new Student { Id=10,Name="hesham" ,Image="1.png"});
        }

        public Student getStudents(int id)
        {
            return students.FirstOrDefault(S => S.Id==id);
        }
        public List<Student> GETALLSTUDENTS()
        {
            return students;
        }
    }
}
