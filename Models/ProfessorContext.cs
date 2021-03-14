using Microsoft.EntityFrameworkCore;

namespace PagingSortingDemo.Models
{
    public class ProfessorContext : DbContext
    {
        public ProfessorContext (DbContextOptions<ProfessorContext> options)
            : base(options)
        {
        }

        public DbSet<Professor> Professor {get; set;}
    }
}