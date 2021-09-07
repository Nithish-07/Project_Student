using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentProject.Data.Repositories;
using StudentProject.Domain;

namespace StudentProject.UI.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IStudentRepository repository;

        [BindProperty]
        public Student EditStudent { get; set; }
        public CreateModel(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet(int? Id)
        {
            if (Id.HasValue) 
            {
                EditStudent = repository.GetIndividualStudentDetail(Id.Value);
            }
            else
            {
                EditStudent = new Student();
            }
            
            
        }
        public IActionResult OnPost()
        {
            if(EditStudent.Id > 0)
            {
                EditStudent = repository.UpdateStudentDetail(EditStudent);
                return RedirectToPage("List");
            }
            else
            {
                    repository.AddStudentDetail(EditStudent);
                return RedirectToPage("List");
            }
            
        }

    }
}
