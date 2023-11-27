using BlazorDotNet8Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDotNet8Crud.Data
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
