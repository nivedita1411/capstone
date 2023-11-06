using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmpApi.Models;

public partial class EmsdatabaseContext : DbContext
{
    public EmsdatabaseContext()
    {
    }

    public EmsdatabaseContext(DbContextOptions<EmsdatabaseContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=EMSDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
