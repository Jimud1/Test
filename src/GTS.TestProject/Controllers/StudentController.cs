using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GTS.Data.Repository;
using System;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GTS.TestProject.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IRepository _studentRepository;

        public StudentController(IRepository repository)
        {
            _studentRepository = repository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            try
            {
                return new string[] { "value1", "value2" };
            }
            catch(Exception ex)
            {
                return new List<string> { ex.Message };
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
