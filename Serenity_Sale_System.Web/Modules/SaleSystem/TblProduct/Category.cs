using Serenity.ComponentModel;
using System.ComponentModel;

namespace Serenity_Sale_System.SaleSystem
{
    [EnumKey("Product.Category")]
    public enum ProductCategory
    {
        [Description("Labtop")]
        Labtop = 1,
        [Description("Mobile")]
        Mobile = 2,
        [Description("Screen")]
        Screen = 3,
        [Description("Other")]
        Other =  4
    }
}