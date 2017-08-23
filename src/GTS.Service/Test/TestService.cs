using GTS.Models.ServiceModels;

namespace GTS.Service.Test
{
    public class TestService : ITestService
    {
        /// <summary>
        /// Implementation of test get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestModel Get(int? id)
        {
            return new TestModel {Name = $"{id}" };
        }
    }
}
