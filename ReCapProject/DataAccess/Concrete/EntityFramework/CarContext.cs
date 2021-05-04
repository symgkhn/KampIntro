using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDatabases;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Car>().ToTable("Cars", "dbo"); // sonda dbo yazmamizin sebebi hangi dosya turu oldugu 
            //eger baska bir dosya turuyse onu yaziniz
            modelBuilder.Entity<Car>().Property(p => p.Id).HasColumnName("Id"); //column name olarak db de ne uyaziyosa onu yazicaz
            modelBuilder.Entity<Car>().Property(p => p.BrandId).HasColumnName("BrandId");
            modelBuilder.Entity<Car>().Property(p => p.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(p => p.DailyPrice).HasColumnName("DailyPrice");
            modelBuilder.Entity<Car>().Property(p => p.ModelYear).HasColumnName("ModelYear");
           


        }
    }
}
