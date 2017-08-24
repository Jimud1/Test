using GTS.Data.Entities;
using GTS.Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace GTS.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new StudentMap(modelBuilder.Entity<Student>());
        }
    }
}
