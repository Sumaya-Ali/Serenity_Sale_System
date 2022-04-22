using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Forms
{
    [FormScript("SaleSystem.TblCustomer")]
    [BasedOnRow(typeof(TblCustomerRow), CheckNames = true)]
    public class TblCustomerForm
    {
        [Placeholder("company name")]
        public string CompanyName { get; set; }
        [Placeholder("contact name")]
        public string ContactName { get; set; }
        [Placeholder("contact title")]
        public string ContactTitle { get; set; }
        [Placeholder("customer address")]
        public string Address { get; set; }
        [Hint("chose customer country")]
        public CustomerCountry Country { get; set; }
        [Placeholder("customer phone")]
        public string Phone { get; set; }
        [Placeholder("customer fax")]
        public string Fax { get; set; }
        [Placeholder("customer email")]
        public string Email { get; set; }
    }
}