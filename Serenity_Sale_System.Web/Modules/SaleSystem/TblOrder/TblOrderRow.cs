using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity_Sale_System.SaleSystem
{
    [ConnectionKey("SaleSystem"), Module("SaleSystem"), TableName("[dbo].[TblOrder]")]
    [DisplayName("Orders"), InstanceName("Order")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TblOrderRow : Row<TblOrderRow.RowFields>, IIdRow
    {
        [DisplayName("Order Id"), Identity, IdProperty,QuickSearch(SearchType.StartsWith), NameProperty]
        public int? OrderId
        {
            get => fields.OrderId[this];
            set => fields.OrderId[this] = value;
        }

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[TblCustomer]", "CustomerId"), LeftJoin("jCustomer")]
        [LookupEditor(typeof(TblCustomerRow), InplaceAdd = true,DialogType ="Serenity_Sale_System.SaleSystem.TblCustomerDialog")]
        public int? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Order date"), NotNull]
        public DateTime? OrderDate
        {
            get => fields.OrderDate[this];
            set => fields.OrderDate[this] = value;
        }
        
        [DisplayName("Company name"), Expression("jCustomer.[CompanyName]"),QuickSearch,EditLink]
        public string CustomerCompanyName
        {
            get => fields.CustomerCompanyName[this];
            set => fields.CustomerCompanyName[this] = value;
        }

        [DisplayName("Contact name"), Expression("jCustomer.[ContactName]"),QuickSearch]
        public string CustomerContactName
        {
            get => fields.CustomerContactName[this];
            set => fields.CustomerContactName[this] = value;
        }

        [DisplayName("Contact title"), Expression("jCustomer.[ContactTitle]"),QuickSearch]
        public string CustomerContactTitle
        {
            get => fields.CustomerContactTitle[this];
            set => fields.CustomerContactTitle[this] = value;
        }

        [DisplayName("Customer Address"), Expression("jCustomer.[Address]")]
        public string CustomerAddress
        {
            get => fields.CustomerAddress[this];
            set => fields.CustomerAddress[this] = value;
        }

        [DisplayName("Country"), Expression("jCustomer.[Country]")]
        public CustomerCountry? CustomerCountry
        {
            get => (CustomerCountry?)fields.CustomerCountry[this];
            set => fields.CustomerCountry[this] = (short?)value;
        }

        [DisplayName("Customer Phone"), Expression("jCustomer.[Phone]")]
        public string CustomerPhone
        {
            get => fields.CustomerPhone[this];
            set => fields.CustomerPhone[this] = value;
        }

        [DisplayName("Customer Fax"), Expression("jCustomer.[Fax]")]
        public string CustomerFax
        {
            get => fields.CustomerFax[this];
            set => fields.CustomerFax[this] = value;
        }

        [DisplayName("Customer Email"), Expression("jCustomer.[Email]")]
        public string CustomerEmail
        {
            get => fields.CustomerEmail[this];
            set => fields.CustomerEmail[this] = value;
        }

        public TblOrderRow()
            : base()
        {
        }

        public TblOrderRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderId;
            public Int32Field CustomerId;
            public DateTimeField OrderDate;

            public StringField CustomerCompanyName;
            public StringField CustomerContactName;
            public StringField CustomerContactTitle;
            public StringField CustomerAddress;
            public Int16Field CustomerCountry;
            public StringField CustomerPhone;
            public StringField CustomerFax;
            public StringField CustomerEmail;

        }
    }
}
