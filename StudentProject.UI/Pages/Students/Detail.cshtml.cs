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
    public class DetailModel : PageModel
    {
        private readonly IStudentRepository repository;
        public Student IndividualData { get; set; }

        public DetailModel(IStudentRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet(int Id)
        {
            IndividualData = repository.GetIndividualStudentDetail(Id);
        }
    }
}
