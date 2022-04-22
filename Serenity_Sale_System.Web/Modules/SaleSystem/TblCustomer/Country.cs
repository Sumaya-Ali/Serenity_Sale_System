using Serenity.ComponentModel;
using System.ComponentModel;

namespace Serenity_Sale_System.SaleSystem
{
    [EnumKey("Customer.Country")]
    public enum CustomerCountry
    {
        [Description("Syria")]
        Syria = 1,
        [Description("Iraq")]
        Iraq = 2,
        [Description("Gordan")]
        Gordan = 3
    }
}