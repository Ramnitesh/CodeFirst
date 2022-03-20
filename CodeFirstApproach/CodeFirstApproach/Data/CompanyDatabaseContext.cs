using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproach.Data
{
    public class CompanyDatabaseContext : DbContext
    {
        public CompanyDatabaseContext(DbContextOptions<CompanyDatabaseContext> options) : base(options)
        {

        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Company");

            
            builder.ApplyConfiguration(new CustomersEnityTypeConfiguration());
            base.OnModelCreating(builder);
            builder.Entity<__EFMigrationsHistory>().HasKey(p => p.MigrationId);
            builder.Entity<__EFMigrationsHistory>().ToTable("__EFMigrationsHistory", "Company");

            //builder.Entity<Student>().MapToStoredProcedures();
        }
        public class __EFMigrationsHistory
        {
            public string MigrationId { get; set; }
            public string ProductVersion { get; set; }
        }
    }
}
