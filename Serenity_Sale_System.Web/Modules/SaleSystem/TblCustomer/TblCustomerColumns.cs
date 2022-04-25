using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Columns
{
    [ColumnsScript("SaleSystem.TblCustomer")]
    [BasedOnRow(typeof(TblCustomerRow), CheckNames = true)]
    public class TblCustomerColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,Ignore]
        public int CustomerId { get; set; }
        [EditLink]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        [QuickFilter]
        public short Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}