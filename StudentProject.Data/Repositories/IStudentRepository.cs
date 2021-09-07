using StudentProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Data.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetIndividualStudentDetail(int id);
        Student GetIndividualStudentDetail(string name);
        Student UpdateStudentDetail(Student student);
        void AddStudentDetail(Student student);
        void DeleteStudentDetail(Student student);

    }
}
