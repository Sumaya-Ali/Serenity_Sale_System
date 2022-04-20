using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity_Sale_System.SaleSystem
{
    [ConnectionKey("SaleSystem"), Module("SaleSystem"), TableName("[dbo].[TblOrderDetails]")]
    [DisplayName("Tbl Order Details"), InstanceName("Tbl Order Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TblOrderDetailsRow : Row<TblOrderDetailsRow.RowFields>, IIdRow
    {
        [DisplayName("Order Detail Id"), Identity, IdProperty]
        public int? OrderDetailId
        {
            get => fields.OrderDetailId[this];
            set => fields.OrderDetailId[this] = value;
        }

        [DisplayName("Order"), NotNull, ForeignKey("[dbo].[TblOrder]", "OrderId"), LeftJoin("jOrder")]
        public int? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[TblProduct]", "ProductId"), LeftJoin("jProduct"), TextualField("ProductProductName")]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Quantity"), NotNull]
        public short? Quantity
        {
            get => fields.Quantity[this];
            set => fields.Quantity[this] = value;
        }

        [DisplayName("Unit Price")]
        public short? UnitPrice
        {
            get => fields.UnitPrice[this];
            set => fields.UnitPrice[this] = value;
        }

        [DisplayName("Discount")]
        public short? Discount
        {
            get => fields.Discount[this];
            set => fields.Discount[this] = value;
        }

        [DisplayName("Total Price"), NotNull]
        public short? TotalPrice
        {
            get => fields.TotalPrice[this];
            set => fields.TotalPrice[this] = value;
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[CustomerId]")]
        public int? OrderCustomerId
        {
            get => fields.OrderCustomerId[this];
            set => fields.OrderCustomerId[this] = value;
        }

        [DisplayName("Order Order Date"), Expression("jOrder.[OrderDate]")]
        public DateTime? OrderOrderDate
        {
            get => fields.OrderOrderDate[this];
            set => fields.OrderOrderDate[this] = value;
        }

        [DisplayName("Product Product Name"), Expression("jProduct.[ProductName]")]
        public string ProductProductName
        {
            get => fields.ProductProductName[this];
            set => fields.ProductProductName[this] = value;
        }

        [DisplayName("Product Product Image"), Expression("jProduct.[ProductImage]")]
        public string ProductProductImage
        {
            get => fields.ProductProductImage[this];
            set => fields.ProductProductImage[this] = value;
        }

        [DisplayName("Product Category"), Expression("jProduct.[Category]")]
        public short? ProductCategory
        {
            get => fields.ProductCategory[this];
            set => fields.ProductCategory[this] = value;
        }

        [DisplayName("Product Description"), Expression("jProduct.[Description]")]
        public string ProductDescription
        {
            get => fields.ProductDescription[this];
            set => fields.ProductDescription[this] = value;
        }

        [DisplayName("Product Price"), Expression("jProduct.[Price]")]
        public string ProductPrice
        {
            get => fields.ProductPrice[this];
            set => fields.ProductPrice[this] = value;
        }

        public TblOrderDetailsRow()
            : base()
        {
        }

        public TblOrderDetailsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderDetailId;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public Int16Field Quantity;
            public Int16Field UnitPrice;
            public Int16Field Discount;
            public Int16Field TotalPrice;

            public Int32Field OrderCustomerId;
            public DateTimeField OrderOrderDate;

            public StringField ProductProductName;
            public StringField ProductProductImage;
            public Int16Field ProductCategory;
            public StringField ProductDescription;
            public StringField ProductPrice;
        }
    }
}
