using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity_Sale_System.SaleSystem.Columns
{
    [ColumnsScript("SaleSystem.TblOrder")]
    [BasedOnRow(typeof(TblOrderRow), CheckNames = true)]
    public class TblOrderColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight,Ignore]
        public int OrderId { get; set; }
        public String CustomerCompanyName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}