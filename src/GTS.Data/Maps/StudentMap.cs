using GTS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GTS.Data.Maps
{
    public class StudentMap
    {
        public StudentMap(EntityTypeBuilder<Student> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.EnrollmentNo).IsRequired();
        }
    }
}
