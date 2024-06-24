using BrandApplication.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.DataAccess
{
	public class BrandDbContext : DbContext
	{
		public BrandDbContext(DbContextOptions<BrandDbContext> options) : base(options)
		{
		}

		public DbSet<Brand> Brands { get; set; }
		public DbSet<Model> Models { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new FluentConfiguration.Brand_FluentConfiguration());
			modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 1, BrandName = "Brand 1" });  // Here can seed the Data Initially 
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=TATHEER\\SQLEXPRESS;CleanArchitectureStructure;TrustServerCertificate=True;Trusted_Connection=True;");
			}
		}
	}
}
