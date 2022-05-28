using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CongressionalConsolationGenerator.Models;

namespace CongressionalConsolationGenerator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CongressionalConsolationGenerator.Models.Condolence>? Condolence { get; set; }
    }
}