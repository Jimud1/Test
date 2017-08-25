using System.Collections.Generic;
using GTS.Data.Entities;
using GTS.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace GTS.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {

        private ApplicationContext context;
        private DbSet<StudentEntity> studentEntity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public StudentRepository(ApplicationContext context)
        {
            this.context = context;
            studentEntity = context.Set<StudentEntity>();
        }

        public void Delete(long id)
        {
            StudentEntity student = Get(id);
            studentEntity.Remove(student);
            context.SaveChanges();
        }

        public IEnumerable<StudentEntity> Get()
        {
            return studentEntity.AsEnumerable();
        }

        public StudentEntity Get(long id)
        {
            return studentEntity.SingleOrDefault(s => s.Id == id);
        }

        public void Save(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Save(StudentEntity student)
        {
            context.Entry(student).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentEntity student)
        {
            context.SaveChanges();
        }

        IEnumerable<IBaseEntity> IRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
