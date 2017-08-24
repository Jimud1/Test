using System.Collections.Generic;
using GTS.Data.Entities;
using GTS.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GTS.Data.Repository
{
    public class StudentRepository : IRepository
    {

        private ApplicationContext context;
        private DbSet<Student> studentEntity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public StudentRepository(ApplicationContext context)
        {
            this.context = context;
            studentEntity = context.Set<Student>();
        }

        public void Delete(long id)
        {
            Student student = Get(id);
            studentEntity.Remove(student);
            context.SaveChanges();
        }

        public IEnumerable<IBaseEntity> Get()
        {
            return studentEntity.AsEnumerable();
        }

        public Student Get(long id)
        {
            return studentEntity.SingleOrDefault(s => s.Id == id);
        }

        public void Save(IBaseEntity student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(IBaseEntity student)
        {
            context.SaveChanges();
        }
    }
}
