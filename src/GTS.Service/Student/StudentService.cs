using System;
using System.Collections.Generic;
using System.Linq;
using GTS.Data.Entities;
using GTS.Data.Repository;
using GTS.Models.ServiceModels;

namespace GTS.Service.Student
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Delete(long id)
        {
            _studentRepository.Delete(id);
        }

        public IEnumerable<StudentModel> Get()
        {
            var students = _studentRepository.Get().Select(EntityToModel).ToList();
            return students;
        }

        public StudentModel Get(long id)
        {
            var student = EntityToModel(_studentRepository.Get(id));
            return student;
        }

        public void Save(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Save(StudentModel student)
        {
            var entity = ModelToEntity(student);
            _studentRepository.Save(entity);
        }

        public void Update(IBaseEntity student)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentModel student)
        {
            var entity = ModelToEntity(student);
            _studentRepository.Update(entity);
        }

        private StudentModel EntityToModel(StudentEntity entity)
        {
            var model = new StudentModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Name = $"{entity.FirstName} {entity.LastName}",
                Email = entity.Email,
                EnrollmentNo = entity.EnrollmentNo
            };
            return model;
        }

        IEnumerable<IBaseEntity> IServiceBase.Get()
        {
            throw new NotImplementedException();
        }

        IBaseEntity IServiceBase.Get(long id)
        {
            throw new NotImplementedException();
        }

        private StudentEntity ModelToEntity(StudentModel model)
        {
            var entity = new StudentEntity
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                EnrollmentNo = model.EnrollmentNo
            };
            return entity;
        }
    }
}
