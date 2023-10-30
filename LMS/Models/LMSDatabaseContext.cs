using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMS.Models;

public class LMSDatabaseContext : DbContext
{
    public virtual DbSet<Book> Books {get;set;}
    public virtual DbSet<LibraryCard> LibraryCards {get;set;}

    public LMSDatabaseContext (){}
    public LMSDatabaseContext(DbContextOptions<LMSDatabaseContext> options)
     : base (options)
     {

     }

     protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
     {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=LMSDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
     }


}