using BookManagerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagerAPI.DB
{
    public class BookDB : DbContext
    {
        public BookDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure unique constraints
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

           

            // Seed some categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", Description = "Fictional literature" },
                new Category { Id = 2, Name = "Non-fiction", Description = "Based on facts and real events" },
                new Category { Id = 3, Name = "Science Fiction", Description = "Scientific and technological themes" },
                new Category { Id = 4, Name = "Mystery", Description = "Fiction dealing with the solution of a crime" }
            );
        }

    }
}
