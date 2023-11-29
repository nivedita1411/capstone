using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace piroozectt.Models;

public class AppDbContext : DbContext
{
    public virtual DbSet<Booking> Bookings {get;set;}
    public virtual DbSet<Event> Events {get;set;}
    public virtual DbSet<Payment> Payments {get;set;}
    public virtual DbSet<User> Users {get;set;}

    public AppDbContext(){}
    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base (options)
     {
     }
     protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
     {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer ("User ID=sa;password=examlyMssql@123; server=localhost;Database=SiddhiDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
     }
}