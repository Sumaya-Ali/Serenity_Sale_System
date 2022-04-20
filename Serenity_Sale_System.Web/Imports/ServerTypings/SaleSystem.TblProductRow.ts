namespace Serenity_Sale_System.SaleSystem {
    export interface TblProductRow {
        ProductId?: number;
        ProductName?: string;
        ProductImage?: string;
        Category?: number;
        Description?: string;
        Price?: string;
    }

    export namespace TblProductRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'SaleSystem.TblProduct';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            ProductName = "ProductName",
            ProductImage = "ProductImage",
            Category = "Category",
            Description = "Description",
            Price = "Price"
        }
    }
}
