using ExerciseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.EntitiesMapConfig
{
    public class BasketEntityMap : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.ProductId);

            builder.Property(_ => _.ProductCount)
                .IsRequired();

            builder.Property(_ => _.price)
                .IsRequired();

            builder.Property(_ => _.TotalPrice);

            builder.HasMany(_ => _.Products);
        }
    }
}
