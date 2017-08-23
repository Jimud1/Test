using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GTS.Service.Test;
using GTS.Models.ServiceModels;
using System;

namespace GTS.TestProject.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        // GET: api/test
        [HttpGet]
        public IEnumerable<TestModel> Get()
        {
            var modelList = new List<TestModel>();
            const int numToReturn = 5;
            
            for(int i = 0; i <= numToReturn; i++)
            {
                var model = new TestModel
                {
                    Name = $"{i}"
                };
                modelList.Add(model);
            }

            return modelList;
        }

        // GET api/test/5
        [HttpGet("{id}")]
        public TestModel Get(int? id)
        {
            if (id == null) throw new NullReferenceException("Id must not be null");

            var model = _testService.Get(id);

            return model;
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
