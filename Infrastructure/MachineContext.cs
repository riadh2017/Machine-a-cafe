using DataModel;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure
{
    public class MachineContext : DbContext
    {
        public MachineContext(DbContextOptions<MachineContext> options)
      : base(options)
        {
        }

        public DbSet<Utilisateurs> Utilisateurs { get; set; }
        public DbSet<Produits> Produits { get; set; }
        public DbSet<Choix_utilisateurs> Choix_utilisateurs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Utilisateurs>().ToTable("Utilisateurs").HasKey(u=>u.Num_Badge);
            builder.Entity<Produits>().ToTable("Produits").HasKey(p=>p.Id);
            builder.Entity<Choix_utilisateurs>().ToTable("Choix_utilisateurs").HasKey(t=>t.Num_Badge);

        }
    }
}
