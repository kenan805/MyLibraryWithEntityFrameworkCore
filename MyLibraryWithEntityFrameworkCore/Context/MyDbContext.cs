using Microsoft.EntityFrameworkCore;
using MyLibraryWithEntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryWithEntityFrameworkCore.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<BookType>? BookTypes { get; set; }
        public DbSet<Operation>? Operations { get; set; }
        public DbSet<Student>? Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WIN-ML3N7I995PP;Initial Catalog=MyLibraryEntity1;User ID=sa;Password=asus1212;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>().Ignore("Id");
            modelBuilder.Entity<Operation>().HasKey("StudentId", "BookId");
            base.OnModelCreating(modelBuilder);
        }
    }
}
