using GTS.Data.Entities;
using System.Collections.Generic;

namespace GTS.Service
{
    public interface IServiceBase
    {
        void Save(IBaseEntity student);
        IEnumerable<IBaseEntity> Get();
        IBaseEntity Get(long id);
        void Delete(long id);
        void Update(IBaseEntity student);
    }
}
