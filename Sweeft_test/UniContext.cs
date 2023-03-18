using Microsoft.EntityFrameworkCore;

namespace Sweeft_test
{
    public class UniContext : DbContext
    {
        public UniContext(DbContextOptions<UniContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
