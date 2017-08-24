using System.Collections.Generic;
using GTS.Data.Entities;
using GTS.Data.Repository;

namespace GTS.Service.Student
{
    public class StudentService : IStudentService
    {
        private readonly IRepository _studentRepository;

        public StudentService(IRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Delete(long id)
        {
            _studentRepository.Delete(id);
        }

        public IEnumerable<IBaseEntity> Get()
        {
            return _studentRepository.Get();
        }

        public IBaseEntity Get(long id)
        {
            return _studentRepository.Get(id);
        }

        public void Save(IBaseEntity student)
        {
            _studentRepository.Save(student);
        }

        public void Update(IBaseEntity student)
        {
            _studentRepository.Update(student);
        }
    }
}
