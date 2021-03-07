using ExerciseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExerciseProject.Models.EntitiesMapConfig
{
    public class OrderEntityMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).
                ValueGeneratedOnAdd();

            builder.Property(_ => _.OrderDate)
                .IsRequired();

            builder.Property(_ => _.TotalAmount);

            builder.HasMany(_ => _.OrderDetails)
                .WithOne(_ => _.Order)
                .HasForeignKey(_ => _.OrderId);

        }
    }
}
