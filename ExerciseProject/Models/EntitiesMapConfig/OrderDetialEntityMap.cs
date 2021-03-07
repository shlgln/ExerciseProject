using ExerciseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.EntitiesMapConfig
{
    public class OrderDetialEntityMap : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id)
                .ValueGeneratedOnAdd();

            builder.Property(_ => _.OrderId);

            builder.Property(_ => _.ProductId);

            builder.Property(_ => _.ProductCount)
                .IsRequired();

            builder.Property(_ => _.ProductPrice)
                .IsRequired();

            builder.Property(_ => _.TotalPrice);

            builder.HasOne(_ => _.Order);

            builder.HasMany(_ => _.Products);
        }
    }
}
