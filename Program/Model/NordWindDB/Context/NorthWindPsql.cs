using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Program.Model.NordWindDB
{
    internal class NorthWindPsql : DbContext
    {
        internal DbSet<Category> Categories { get; set; } = null!;


        public NorthWindPsql()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host = 192.168.0.156; Port = 5432; Database = test1; Username = remoteuser; Password = qwerty");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Category>()
            .HasKey(c => c.CategoryID);

            modelBuilder.Entity<Category>()
            .Property(c => c.CategoryName)
            .IsRequired()
            .HasMaxLength(15);
        }
    }
}