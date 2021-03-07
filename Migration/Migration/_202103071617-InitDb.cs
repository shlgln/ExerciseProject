using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.Migration
{
    [Migration(202103071617)]
    public class _202103071617_InitDb : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("productCategories")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Title").AsString(50).NotNullable()
                .WithColumn("ParentId").AsInt32().ForeignKey().Nullable();

            Create.Table("Products")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("CategoryId").AsInt32().ForeignKey("FK_Products_Category", "productCategories", "Id").NotNullable()
                .WithColumn("Title").AsString(100).NotNullable()
                .WithColumn("Count").AsInt32().NotNullable()
                .WithColumn("Price").AsInt32().NotNullable()
                .WithColumn("Description").AsString().Nullable();

            Create.Table("Baskets")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("ProductId").AsInt32().ForeignKey("FK_Products", "Products", "Id").NotNullable()
                .WithColumn("ProductCount").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();

            Create.Table("Orders")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("OrderDate").AsDateTime()
                .WithColumn("TotalAmount").AsInt32().NotNullable();

            Create.Table("OrderDetails")
                 .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("OrderId").AsInt32().NotNullable().ForeignKey("FK_Orders", "Orders", "Id")
                 .WithColumn("ProductId").AsInt32().NotNullable()
                 .WithColumn("ProductCount").AsInt32().NotNullable()
                 .WithColumn("ProductPrice").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("productCategories");
            Delete.Table("Products");
            Delete.Table("Baskets");
            Delete.Table("OrderDetails");
            Delete.Table("Orders");
        }
    }
}
