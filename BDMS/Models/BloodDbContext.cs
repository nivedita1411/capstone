using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BDMS.Models

{

public class BloodDbContext : DbContext
{
    public virtual DbSet<BloodDonor> Donors {get;set;}

    public BloodDbContext(){}

    public BloodDbContext (DbContextOptions<BloodDbContext> options) : base(options)
    {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=BloodDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
    
}

}
