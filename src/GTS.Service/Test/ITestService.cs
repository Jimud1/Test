using GTS.Models.ServiceModels;

namespace GTS.Service.Test
{
    public interface ITestService
    {
        /// <summary>
        /// Test Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TestModel Get(int? id);
    }
}
