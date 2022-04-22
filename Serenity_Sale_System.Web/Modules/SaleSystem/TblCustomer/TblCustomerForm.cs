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
        [TextAreaEditor(Rows = 3)]
        public string Address { get; set; }
        [Hint("chose customer country")]
        public CustomerCountry Country { get; set; }
        [Placeholder("customer phone")]
        [IntegerEditor]
        public string Phone { get; set; }
        [Placeholder("customer fax")]
        [IntegerEditor]
        public string Fax { get; set; }
        [Placeholder("customer email")]
        [EmailEditor]
        public string Email { get; set; }
    }
}