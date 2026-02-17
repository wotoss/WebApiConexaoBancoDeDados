using Microsoft.EntityFrameworkCore;
using WebApiCrudProfessor.Modelo;

namespace WebApiCrudProfessor.DataBase
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext(DbContextOptions<ProfessorDbContext> options)
            :base(options)
        { }

        public DbSet<Professor> Professores { get; set; }

    }
}
