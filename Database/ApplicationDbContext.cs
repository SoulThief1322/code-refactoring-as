using CodeRefactoring.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Namespace
{
    public class DbContext : IdentityDbContext<CodeRefactoring.Data.Models.User>
    {
        public DbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public override DbSet<User> Users { get; set; }
    }
}