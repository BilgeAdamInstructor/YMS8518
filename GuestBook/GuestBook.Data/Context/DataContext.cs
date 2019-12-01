using GuestBook.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace GuestBook.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<GuestNote> GuestNotes { get; set; }
    }
}