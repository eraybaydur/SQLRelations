using Microsoft.EntityFrameworkCore;
using SQLRelations.BireBir;
using SQLRelations.BireCok;

namespace SQLRelations
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=SQLRelations;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //BIRE BIR ILISKI
            modelBuilder.Entity<Kullanici>()
                .HasOne(k => k.Profil)
                .WithOne(p => p.Kullanici)
                .HasForeignKey<Profil>(p => p.KullaniciId);

            //BIRE COK ILISKI
            modelBuilder.Entity<Kategori>()
                .HasMany(k => k.Urunler)
                .WithOne(p => p.Kategori)
                .HasForeignKey(p => p.KategoriId);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
