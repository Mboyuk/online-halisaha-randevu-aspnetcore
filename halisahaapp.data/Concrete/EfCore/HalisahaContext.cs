using System;
using halisahaapp.entity;
using Microsoft.EntityFrameworkCore;

namespace halisahaapp.data.Concrete.EfCore
{
    public class HalisahaContext : DbContext
    {


        public DbSet<Halisaha> Halisahas { get; set; }
        public DbSet<Property> Properties { get; set; }

        public DbSet<HalisahaProperty> HalisahaProperties { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<PreTransaction> PreTransactions { get; set; }

        public string DbPath { get; private set; }
        public HalisahaContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}sok.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=HalisahaDb;user=root;password=Galeri042.;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<OgrenciDers>()
            //     .HasKey(c => new { c.DersId, c.OgrenciId });
        }

    }
}