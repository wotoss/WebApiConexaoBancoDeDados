using Microsoft.EntityFrameworkCore;

namespace WebApiCrudProfessor.DataBase
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext(DbContextOptions<ProfessorDbContext> options)
            :base(options)
        { }
    }
}
