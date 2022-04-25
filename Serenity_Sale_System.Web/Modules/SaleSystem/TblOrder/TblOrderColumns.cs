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
        [EditLink,  AlignRight]
        public int OrderId { get; set; }
        [QuickFilter]
        public String CustomerCompanyName { get; set; }       
        public  String CustomerContactName {get; set; }        
        public String CustomerContactTitle {get; set;}
        [QuickFilter]
        public short CustomerCountry {get; set;}
        public DateTime OrderDate { get; set; }
    }
}