using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProject.Data;
using StudentProject.Data.Repositories;
using StudentProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository repository;
        private readonly StudentDBContext db;

        public StudentController(IStudentRepository repository, StudentDBContext db)
        {
            this.repository = repository;
            this.db = db;
        }
        //[HttpGet("api/Students")]
        public IActionResult GetAllStudents()
        {
            var data = repository.GetAllStudents();
            var some = db.Students as IQueryable<Student>;
            some = (IQueryable<Student>)data; 
            return new JsonResult(some);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetStudent(int id)
        {
            var data = repository.GetIndividualStudentDetail(id);
            
            return Ok(data);
        }
        [HttpGet("{name}")]
        public IActionResult GetStudentDetail(string name)
        {
            var data = repository.GetIndividualStudentDetail(name);
            return new JsonResult(data);
        }

    }
}
