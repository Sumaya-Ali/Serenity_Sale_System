namespace Serenity_Sale_System.SaleSystem {
    export interface TblOrderDetailsRow {
        OrderDetailId?: number;
        OrderId?: number;
        ProductId?: number;
        Quantity?: number;
        UnitPrice?: number;
        Discount?: number;
        TotalPrice?: number;
        OrderCustomerId?: number;
        OrderOrderDate?: string;
        ProductProductName?: string;
        ProductProductImage?: string;
        ProductCategory?: number;
        ProductDescription?: string;
        ProductPrice?: string;
    }

    export namespace TblOrderDetailsRow {
        export const idProperty = 'OrderDetailId';
        export const localTextPrefix = 'SaleSystem.TblOrderDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderDetailId = "OrderDetailId",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            UnitPrice = "UnitPrice",
            Discount = "Discount",
            TotalPrice = "TotalPrice",
            OrderCustomerId = "OrderCustomerId",
            OrderOrderDate = "OrderOrderDate",
            ProductProductName = "ProductProductName",
            ProductProductImage = "ProductProductImage",
            ProductCategory = "ProductCategory",
            ProductDescription = "ProductDescription",
            ProductPrice = "ProductPrice"
        }
    }
}
