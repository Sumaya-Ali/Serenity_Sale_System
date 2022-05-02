using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Forms
{
    [FormScript("SaleSystem.TblOrder")]
    [BasedOnRow(typeof(TblOrderRow), CheckNames = true)]
    public class TblOrderForm
    {
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [TblOrderDetailsEditor, IgnoreName,DisplayName("Details")]
        public List<TblOrderDetailsRow> OrderDetailsList { get; set; }
    }
}