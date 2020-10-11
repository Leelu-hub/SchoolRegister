using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolRegister.Domain.Models;
using SchoolRegister.Repository;

namespace SchoolRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private SchoolRegisterContext _db;
        public StudentController(SchoolRegisterContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            Student[] students = _db.Students.ToArray();
            

            return students;
        }
    }
}