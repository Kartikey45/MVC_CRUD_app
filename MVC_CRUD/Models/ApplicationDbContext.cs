using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EmpDetails> EmployeeDetails { get; set; }

    /*
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                *//*--------------------------------------------------------------------------------------------------------------*/


                /*builder.Entity<EmpDetails>().HasKey(m => m.Id);

                builder.Entity<EmpDetails>().Property<DateTime>("UpdatedTimestamp");

                base.OnModelCreating(builder);*/


                /*--------------------------------------------------------------------------------------------------------------*/

    /*
                // Use Fluent API to configure  

                // Map entities to tables  
                modelBuilder.Entity<EmpDetails>().ToTable("EmployeeDetails");

                // Configure Primary Keys  
                modelBuilder.Entity<EmpDetails>().HasKey(ug => ug.Id).HasName("PK_EmployeeDetails");
    *//*

            }
    */
    }
}
