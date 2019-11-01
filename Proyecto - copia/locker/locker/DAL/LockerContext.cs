using locker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace locker.DAL
{
    public class LockerContext : DbContext
    {
        public LockerContext() : base("LockerContext")
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<GestionDeLibro> GestionDeLibros { get; set; }
        public DbSet<Register> Registrer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {       
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<locker.Models.Login> Logins { get; set; }
    }
}