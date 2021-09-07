using StudentProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDBContext context;

        public StudentRepository(StudentDBContext context)
        {
            this.context = context;
        }

        public void AddStudentDetail(Student student)
        {
            student.TeacherId = 1;
            context.Students.Add(student);
            context.SaveChanges();

        }

        public void DeleteStudentDetail(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return from a in context.Students select a;
        }

        public Student GetIndividualStudentDetail(int id)
        {
            return context.Students.Where(e => e.Id == id).SingleOrDefault();
            
        }

        public Student GetIndividualStudentDetail(string name)
        {
            return context.Students.Where(e => e.Name.Equals(name)).Single();
        }

        public Student UpdateStudentDetail(Student student)
        {
            if(student == null)
            {
                return null;
            }
            var data = context.Students.Where(e => e.Id == student.Id).Single();
            if(data != null)
            {
                data.Name = student.Name;
                context.SaveChanges();
                return data;

            }
            return null;
        }
    }
}
