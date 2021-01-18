using Microsoft.EntityFrameworkCore;
using MvcBook.Models;

namespace MvcBook.Data
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}