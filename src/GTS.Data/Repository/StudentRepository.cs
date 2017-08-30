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

        private ApplicationContext _context;
        private DbSet<StudentEntity> _studentEntity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public StudentRepository(ApplicationContext context)
        {
            _context = context;
            _studentEntity = context.Set<StudentEntity>();
        }

        public void Delete(long id)
        {
            StudentEntity student = Get(id);
            _studentEntity.Remove(student);
            _context.SaveChanges();
        }

        public IEnumerable<StudentEntity> Get()
        {
            var entities = _studentEntity.AsEnumerable();
            return entities;
        }

        public StudentEntity Get(long id)
        {
            return _studentEntity.SingleOrDefault(s => s.Id == id);
        }

        public void Save(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Save(StudentEntity student)
        {
            _context.Entry(student).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentEntity student)
        {
            _context.SaveChanges();
        }

        IEnumerable<IBaseEntity> IRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
