using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using GTS.Service.Student;
using GTS.Models.ServiceModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GTS.TestProject.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService service)
        {
            _studentService = service;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<StudentModel> Get()
        {
            try
            {
                var students = _studentService.Get();
                return students;
            }
            catch(Exception ex)
            {
                throw ex;
            }

}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            try
            {
                return "value";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
