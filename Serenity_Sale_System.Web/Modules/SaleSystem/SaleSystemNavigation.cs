using Serenity.Navigation;
using MyPages = Serenity_Sale_System.SaleSystem.Pages;

[assembly: NavigationLink(int.MaxValue, "SaleSystem/Tbl Customer", typeof(MyPages.TblCustomerController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SaleSystem/Tbl Order", typeof(MyPages.TblOrderController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SaleSystem/Tbl Order Details", typeof(MyPages.TblOrderDetailsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "SaleSystem/Tbl Product", typeof(MyPages.TblProductController), icon: null)]