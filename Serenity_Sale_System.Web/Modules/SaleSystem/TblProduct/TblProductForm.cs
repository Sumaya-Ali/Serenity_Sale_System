using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Forms
{
    [FormScript("SaleSystem.TblProduct")]
    [BasedOnRow(typeof(TblProductRow), CheckNames = true)]
    public class TblProductForm
    {
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public short Category { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}