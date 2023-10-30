using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EMS_Codefirst.Models;

public class EMSDatabaseContext : DbContext
{
    public virtual DbSet<Dept> Depts {get;set;}
    public virtual DbSet<Employee> Employees {get;set;}

    public EMSDatabaseContext(){}
    public EMSDatabaseContext(DbContextOptions<EMSDatabaseContext> options)
     : base (options)
     {
     }
     protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
     {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer ("User ID=sa;password=examlyMssql@123; server=localhost;Database=EMSDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
     }
}