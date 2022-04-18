using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Serenity_Sale_System.Migrations.SaleSystemDB
{

    [Migration(20220418140000)]
    public class SaleSystemDB_20220418_140000_DBTables : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("TblCustomer")
                .WithColumn("CustomerId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CompanyName").AsString(100).Nullable()
                .WithColumn("ContactName").AsString(100).NotNullable()
                .WithColumn("ContactTitle").AsString(100).Nullable()
                .WithColumn("Address").AsString(150).Nullable()
                .WithColumn("Country").AsInt16().NotNullable()
                .WithColumn("Phone").AsString(15).Nullable()
                .WithColumn("Fax").AsString(15).Nullable()
                .WithColumn("Email").AsString(50).Nullable();
            
            Insert.IntoTable("TblCustomer").Row(new {
                CompanyName = "Syriatel",
                ContactName = "Sumaya Ali",
                ContactTitle = "Marketing Manager",
                Address = "Damascus babtoma",
                Country = 1,
                Phone = "00963937823211",
                Fax = "0012345",
                Email = "SumayaJalalAli@gmail.com"
            });

            Insert.IntoTable("TblCustomer").Row(new {
                CompanyName = "MTN",
                ContactName = "Ola Tobal",
                ContactTitle = "Sales Representative",
                Address = "Damascus Jaramana",
                Country = 1,
                Phone = "00963123456788",
                Fax = "006789",
                Email = "OlaTobal@Yahoo.com"
            });

            Insert.IntoTable("TblCustomer").Row(new {
                CompanyName = "AlSamah",
                ContactName = "Ahed Wattar",
                ContactTitle = "Accounting Manager",
                Address = "Baghdad",
                Country = 2,
                Phone = "00964789666287",
                Fax = "",
                Email = "AhedWattar@gmail.com"
            });

            Create.Table("TblProduct")
                .WithColumn("ProductId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("ProductName").AsString(100).NotNullable()
                .WithColumn("ProductImage").AsString(300).Nullable()
                .WithColumn("Category").AsInt16().Nullable()
                .WithColumn("Description").AsString(300).Nullable()
                .WithColumn("Price").AsString(50).Nullable();
            
            Insert.IntoTable("TblProduct").Row(new {
                ProductName = "ASUS Laptope",
                ProductImage = "",
                Category = 1,
                Description = "Ram 8 G, Hard 500 G",
                Price = "1000$"
            });
            
            Insert.IntoTable("TblProduct").Row(new {
                ProductName = "Note 9 pro",
                ProductImage = "",
                Category = 2,
                Description = "Ram 6 G, Hard 128 G",
                Price = "300$"
            });

            Insert.IntoTable("TblProduct").Row(new {
                ProductName = "Toshipa Laptope",
                ProductImage = "",
                Category = 1,
                Description = "Ram 16 G, Hard 1 T",
                Price = "1500$"
            });

            Create.Table("TblOrder")
                .WithColumn("OrderId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("CustomerId").AsInt32().NotNullable()
                .ForeignKey("FK_TblOrder_CustomerId", "TblCustomer", "CustomerId")
                .WithColumn("OrderDate").AsDate().NotNullable();
            
            Create.Table("TblOrderDetails")
                .WithColumn("OrderDetailId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("OrderId").AsInt32().NotNullable()
                .ForeignKey("FK_TblOrderDetails_OrderId", "TblOrder", "OrderId")
                
                .WithColumn("ProductId").AsInt32().NotNullable()
                .ForeignKey("FK_TblOrderDetails_ProductId", "TblProduct", "ProductId")
                .WithColumn("Quantity").AsInt16().NotNullable()
                .WithColumn("UnitPrice").AsInt16().Nullable()
                .WithColumn("Discount").AsInt16().Nullable()
                .WithColumn("TotalPrice").AsInt16().NotNullable();
        }
    }
}