using Microsoft.EntityFrameworkCore;

namespace CodigoSistClases.Models
{
    public class DemoContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ETHPHOS; Database=Codigo2024SisClases; Integrated Security=True; Trust Server Certificate=True");
        }
    }


}
