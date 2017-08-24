using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTS.Models.ServiceModels
{
    public class StudentModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EnrollmentNo { get; set; }
    }
}
