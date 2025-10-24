using CodeRefactoring.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CodeRefactoring.Data
{
    public class ApplicationDbContext : IdentityDbContext<CodeRefactoring.Data.Models.User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public override DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animals");

                entity.HasKey(a => a.Id);

                entity.Property(a => a.Name)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(a => a.Type)
                      .HasMaxLength(100)
                      .HasDefaultValue(string.Empty);

                entity.Property(a => a.IsSick)
                      .HasDefaultValue(false);

                entity.Property(a => a.Age)
                      .HasDefaultValue(0);

                entity.HasIndex(a => a.Name).HasDatabaseName("IX_Animals_Name");
                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey("OwnerId")
                      .IsRequired()
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}