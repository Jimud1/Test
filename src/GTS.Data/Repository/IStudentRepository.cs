using GTS.Data.Entities;
using System.Collections.Generic;

namespace GTS.Data.Repository
{
    public interface IStudentRepository : IRepository
    {
        void Save(StudentEntity student);
        new IEnumerable<StudentEntity> Get();
        new StudentEntity Get(long id);
        new void Delete(long id);
        void Update(StudentEntity student);
    }
}
