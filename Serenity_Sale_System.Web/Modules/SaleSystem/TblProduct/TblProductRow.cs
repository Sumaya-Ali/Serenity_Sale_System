using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity_Sale_System.SaleSystem
{
    [ConnectionKey("SaleSystem"), Module("SaleSystem"), TableName("[dbo].[TblProduct]")]
    [DisplayName("Tbl Product"), InstanceName("Tbl Product")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TblProductRow : Row<TblProductRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Identity, IdProperty]
        public int? ProductId
        {
            get => fields.ProductId[this];
            set => fields.ProductId[this] = value;
        }

        [DisplayName("Product Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string ProductName
        {
            get => fields.ProductName[this];
            set => fields.ProductName[this] = value;
        }

        [DisplayName("Product Image"), Size(300)]
        public string ProductImage
        {
            get => fields.ProductImage[this];
            set => fields.ProductImage[this] = value;
        }

        [DisplayName("Category")]
        public short? Category
        {
            get => fields.Category[this];
            set => fields.Category[this] = value;
        }

        [DisplayName("Description"), Size(300)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Price"), Size(50)]
        public string Price
        {
            get => fields.Price[this];
            set => fields.Price[this] = value;
        }

        public TblProductRow()
            : base()
        {
        }

        public TblProductRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField ProductName;
            public StringField ProductImage;
            public Int16Field Category;
            public StringField Description;
            public StringField Price;
        }
    }
}
