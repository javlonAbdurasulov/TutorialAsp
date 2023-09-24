using Microsoft.EntityFrameworkCore;
using Tutorial.Models;

namespace Tutorial.DataAccess
{
    public class BookDbContext:DbContext
    {
        //private readonly string _connString = "Server=::1; Port=5432;Database=book;User Id=javlon,Password=123";
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseNpgsql(_connString);
        }
    }
}
