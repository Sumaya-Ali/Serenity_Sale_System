using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Forms
{
    [FormScript("SaleSystem.TblOrderDetails")]
    [BasedOnRow(typeof(TblOrderDetailsRow), CheckNames = true)]
    public class TblOrderDetailsForm
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public short UnitPrice { get; set; }
        public short Discount { get; set; }
        public short TotalPrice { get; set; }
    }
}