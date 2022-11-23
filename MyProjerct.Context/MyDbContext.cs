using Microsoft.EntityFrameworkCore;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjerct.Context
{
    public class MyDbContext:DbContext, IContext
    {
        public DbSet<Role> Roles { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Claim> Claims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PermissionsManagement;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().Property(r => r.Name).IsRequired();
        }

    }
}
