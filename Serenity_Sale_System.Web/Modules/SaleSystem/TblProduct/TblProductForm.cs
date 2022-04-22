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
        [Placeholder("product name")]
        public string ProductName { get; set; }
        [Hint("upload product image")]
        public string ProductImage { get; set; }
        [Hint("chose product category")]
        public ProductCategory Category { get; set; }
        [Placeholder("product description")]
        public string Description { get; set; }
        [Placeholder("product price per unit")]
        public string Price { get; set; }
    }
}