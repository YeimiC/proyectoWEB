using Microsoft.EntityFrameworkCore;

namespace Proyecto24BM.Models.Contest
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)

        { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }

    }
}
