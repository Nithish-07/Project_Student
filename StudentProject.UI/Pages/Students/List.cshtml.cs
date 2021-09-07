using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentProject.Data.Repositories;
using StudentProject.Domain;

namespace StudentProject.UI.Pages
{
    public class StudentsModel : PageModel
    {
        private readonly IStudentRepository repository;
        public IEnumerable<Student> StudentDetails { get; set; }

        public StudentsModel(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            StudentDetails = repository.GetAllStudents();
        }
    }
}
