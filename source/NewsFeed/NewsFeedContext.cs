using Microsoft.EntityFrameworkCore;
using NewsFeed.Models;

namespace NewsFeed
{
    public class NewsFeedContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public NewsFeedContext(DbContextOptions<NewsFeedContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NewsFeed;User ID=postgres;Password=postgres;Timeout=1024");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            { 
                entity.ToTable("users");

                entity.Property(u => u.Id)
                      .HasColumnName("id");

                entity.Property(u => u.Name) 
                      .HasColumnName("name");

                entity.Property(u => u.Email)
                     .HasColumnName("email");

                entity.Property(u => u.Role)
                     .HasColumnName("role");

                entity.Property(u => u.Avatar)
                     .HasColumnName("avatar");

                entity.HasKey(u => u.Id);
            });
        }
    }
}