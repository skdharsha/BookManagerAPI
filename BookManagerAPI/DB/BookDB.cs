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
    }
}
