using Microsoft.EntityFrameworkCore;
using MvcBook.Models;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcBook.Areas.Identity.Data;
using MvcBook.Models;

namespace MvcBook.Data
{
    public class MvcBookContext : IdentityDbContext<MvcBookUser>
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        /*  public DbSet<MvcBookUser> MvcBookUser { get; set; }*/
        public DbSet<MvcBookUser> MvcBookUser { get; set; }
        
        public DbSet<BookMvcBookUser> BookMvcBookUser { get; set; }

        public DbSet<Role> Role { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BookMvcBookUser>()
                .HasKey(c => new { c.BookId, c.MvcBookUserId});
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        
       
    }
}

