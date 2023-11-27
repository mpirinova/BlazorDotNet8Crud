using BlazorDotNet8Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDotNet8Crud.Shared.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
