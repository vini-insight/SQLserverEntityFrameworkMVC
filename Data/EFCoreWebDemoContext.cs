using Microsoft.EntityFrameworkCore;
using SQLserverEntityFrameworkMVC.Models;

namespace SQLserverEntityFrameworkMVC.Data
{
    public class EFCoreWebDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=mvcefcore;Trusted_Connection=True;");
        }
    }
}