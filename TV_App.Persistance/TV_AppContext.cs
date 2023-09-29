using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TV_App.Persistance.Models;

namespace TV_App.Persistance
{
    public class TV_AppContext : DbContext
    {
        public TV_AppContext (DbContextOptions<TV_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Series> Series { get; set; }
        public DbSet<Productors> Productors { get; set; }
        public DbSet<Genres> Genres { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Series>().ToTable("Series");
			modelBuilder.Entity<Productors>().ToTable("Productors");
			modelBuilder.Entity<Genres>().ToTable("Genres");

			modelBuilder.Entity<Series>().HasKey(s => s.Id);
			modelBuilder.Entity<Productors>().HasKey(p => p.Id);
			modelBuilder.Entity<Genres>().HasKey(g => g.Id);


			modelBuilder.Entity<Genres>().HasMany<Series>(g => g.Series).WithOne(s => s.Genre).HasForeignKey(s => s.GenreId).OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Productors>().HasMany<Series>(p => p.Series).WithOne(s => s.Productor).HasForeignKey(s => s.ProductorId).OnDelete(DeleteBehavior.Cascade);


			modelBuilder.Entity<Series>().Property(s => s.Id).IsRequired();
			modelBuilder.Entity<Series>().Property(s => s.Name).IsRequired();
			modelBuilder.Entity<Series>().Property(s => s.Video).IsRequired();
			modelBuilder.Entity<Series>().Property(s => s.Img).IsRequired();
			modelBuilder.Entity<Series>().Property(s => s.ProductorId).IsRequired();
			modelBuilder.Entity<Series>().Property(s => s.GenreId).IsRequired();

			modelBuilder.Entity<Genres>().Property(g => g.Id).IsRequired();
			modelBuilder.Entity<Genres>().Property(g => g.Name).IsRequired();

			modelBuilder.Entity<Productors>().Property(p => p.Id).IsRequired();
			modelBuilder.Entity<Productors>().Property(p => p.Name).IsRequired();
			modelBuilder.Entity<Productors>().Property(p => p.Description).IsRequired();
		}

	}
}
