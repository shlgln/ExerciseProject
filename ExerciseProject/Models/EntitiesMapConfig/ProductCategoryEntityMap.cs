using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.EntitiesMapConfig
{
    public class ProductCategoryEntityMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.Title)
                .HasMaxLength(50).IsRequired();

            builder.Property(_ => _.ParentId);

            builder.HasOne<ProductCategory>().
                WithMany(_ => _.ProductCategories)
                .HasForeignKey(_ => _.ParentId);

            builder.HasMany(_ => _.Products)
                .WithOne(_ => _.ProductCategory)
                .HasForeignKey(_ => _.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
