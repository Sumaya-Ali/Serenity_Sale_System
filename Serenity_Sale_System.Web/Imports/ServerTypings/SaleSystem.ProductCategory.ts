namespace Serenity_Sale_System.SaleSystem {
    export enum ProductCategory {
        Labtop = 1,
        Mobile = 2,
        Screen = 3,
        Other = 4
    }
    Serenity.Decorators.registerEnumType(ProductCategory, 'Serenity_Sale_System.SaleSystem.ProductCategory', 'Product.Category');
}
