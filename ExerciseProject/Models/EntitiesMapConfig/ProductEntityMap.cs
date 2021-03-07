using ExerciseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.EntitiesMapConfig
{
    public class ProductEntityMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.Title)
                .IsRequired().HasMaxLength(100);

            builder.Property(_ => _.Count); 

            builder.Property(_ => _.Price);

            builder.Property(_ => _.CategoryId);

            builder.HasOne(_ => _.ProductCategory)
                .WithMany(_ => _.Products)
                .HasForeignKey(_ => _.CategoryId);
        }
    }
}
