using Microsoft.EntityFrameworkCore;

namespace Grade.Models
{
    public class SGMSDbContext : DbContext
    {
        public virtual DbSet<student> students {get;set;}
        public virtual DbSet<grades> gradesDb {get;set;}

        public SGMSDbContext () {}

        public SGMSDbContext (DbContextOptions<SGMSDbContext> options) : base (options)
        {
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=SGMSDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
            }
        }
    }
}