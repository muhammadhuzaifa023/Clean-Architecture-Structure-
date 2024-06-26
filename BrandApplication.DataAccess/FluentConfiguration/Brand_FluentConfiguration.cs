﻿using BrandApplication.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentConfiguration
{
	internal class Brand_FluentConfiguration : IEntityTypeConfiguration<Brand>
	{

		public void Configure(EntityTypeBuilder<Brand> modelBuilder)
		{
			modelBuilder
			   .HasMany<Model>(b => b.Models)
			   .WithOne(b => b.Brand)
			   .HasForeignKey(b => b.BrandId)
			   .OnDelete(DeleteBehavior.Cascade);
		}
	}
}