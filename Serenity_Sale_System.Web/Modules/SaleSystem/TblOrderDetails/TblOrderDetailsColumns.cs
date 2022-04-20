using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Columns
{
    [ColumnsScript("SaleSystem.TblOrderDetails")]
    [BasedOnRow(typeof(TblOrderDetailsRow), CheckNames = true)]
    public class TblOrderDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public String ProductProductName { get; set; }
        public short Quantity { get; set; }
        public short UnitPrice { get; set; }
        public short Discount { get; set; }
        public short TotalPrice { get; set; }
    }
}