using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Contexts
{
    public class HospitalContext : DbContext,IHospitalContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public HospitalContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
           : base(options)

        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseMySql(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
            //if (!dbContextOptionsBuilder.IsConfigured)
            //{
            //    dbContextOptionsBuilder.UseMySql(@"server=localhost;port=3306;database=db;uid=root;");
            //}
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Department>()
             .HasMany<Doctor>(d => d.Doctor)
             .WithOne(d => d.Department)
             .HasForeignKey(d => d.DepartmentId);
            //.OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
