using Serenity.Navigation;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Sale System", icon: "fa-shopping-basket")]

[assembly: NavigationLink(2100, "Sale System/Customers", typeof(Serenity_Sale_System.SaleSystem.Pages.TblCustomerController), icon: "fa-user-o")]
[assembly: NavigationLink(2200, "Sale System/Products", typeof(Serenity_Sale_System.SaleSystem.Pages.TblProductController), icon: "fa-shopping-bag")]
[assembly: NavigationLink(2300, "Sale System/Orders", typeof(Serenity_Sale_System.SaleSystem.Pages.TblOrderController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(2400, "Sale System/Order Details", typeof(Serenity_Sale_System.SaleSystem.Pages.TblOrderDetailsController), icon: "fa-list")]
