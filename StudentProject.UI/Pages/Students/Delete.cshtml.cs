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
    public class DeleteModel : PageModel
    {
        private readonly IStudentRepository repository;
        public Student DeleteStudentRecord { get; set; }

        public DeleteModel(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet(int Id)
        {
            DeleteStudentRecord = repository.GetIndividualStudentDetail(Id);
            repository.DeleteStudentDetail(DeleteStudentRecord);
            return RedirectToPage("List");
        }
    }
}
