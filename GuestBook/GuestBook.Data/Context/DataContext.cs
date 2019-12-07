
using GuestBook.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace GuestBook.Data.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                Password = "12345678"
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<GuestNote> GuestNotes { get; set; }

        public DbSet<User> Users { get; set; }
    }

}
