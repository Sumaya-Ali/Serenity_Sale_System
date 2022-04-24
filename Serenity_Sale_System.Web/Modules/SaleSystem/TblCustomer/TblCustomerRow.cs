using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity_Sale_System.SaleSystem
{
    [ConnectionKey("SaleSystem"), Module("SaleSystem"), TableName("[dbo].[TblCustomer]")]
    [DisplayName("Customers"), InstanceName("Customer")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TblCustomerRow : Row<TblCustomerRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity, IdProperty]
        public int? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Company name"), Size(100), QuickSearch, NameProperty]
        public string CompanyName
        {
            get => fields.CompanyName[this];
            set => fields.CompanyName[this] = value;
        }

        [DisplayName("Contact name"), Size(100), NotNull,QuickSearch]
        public string ContactName
        {
            get => fields.ContactName[this];
            set => fields.ContactName[this] = value;
        }

        [DisplayName("Contact title"), Size(100),QuickSearch]
        public string ContactTitle
        {
            get => fields.ContactTitle[this];
            set => fields.ContactTitle[this] = value;
        }

        [DisplayName("Address"), Size(150),QuickSearch]
        public string Address
        {
            get => fields.Address[this];
            set => fields.Address[this] = value;
        }

        [DisplayName("Country"), NotNull,DefaultValue(CustomerCountry.Syria)]
        public CustomerCountry? Country
        {
            get =>  (CustomerCountry?)fields.Country[this];
            set => fields.Country[this] = (short?)value;
        }

        [DisplayName("Phone"), Size(15),QuickSearch(SearchType.StartsWith)]
        public string Phone
        {
            get => fields.Phone[this];
            set => fields.Phone[this] = value;
        }

        [DisplayName("Fax"), Size(15),QuickSearch(SearchType.StartsWith)]
        public string Fax
        {
            get => fields.Fax[this];
            set => fields.Fax[this] = value;
        }

        [DisplayName("Email"), Size(50),QuickSearch(SearchType.StartsWith)]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        public TblCustomerRow()
            : base()
        {
        }

        public TblCustomerRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public StringField CompanyName;
            public StringField ContactName;
            public StringField ContactTitle;
            public StringField Address;
            public Int16Field Country;
            public StringField Phone;
            public StringField Fax;
            public StringField Email;
        }
    }
}
