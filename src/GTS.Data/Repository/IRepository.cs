using GTS.Data.Entities;
using System.Collections.Generic;

namespace GTS.Data.Repository
{
    public interface IRepository
    {
        void Save(IBaseEntity student);
        IEnumerable<IBaseEntity> Get();
        Student Get(long id);
        void Delete(long id);
        void Update(IBaseEntity student);
    }
}
