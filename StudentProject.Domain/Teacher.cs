using System.Collections.Generic;

namespace StudentProject.Domain
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Student> Students { get; set; }
    }
}