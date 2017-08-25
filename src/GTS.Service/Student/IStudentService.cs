using GTS.Models.ServiceModels;
using System.Collections.Generic;

namespace GTS.Service.Student
{
    public interface IStudentService : IServiceBase
    {
        new void Save(StudentModel student);
        new IEnumerable<StudentModel> Get();
        new StudentModel Get(long id);
        new void Delete(long id);
        new void Update(StudentModel student);
    }
}
