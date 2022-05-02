namespace Serenity_Sale_System.SaleSystem {
    export interface TblOrderRow {
        OrderId?: number;
        CustomerId?: number;
        OrderDate?: string;
        CustomerCompanyName?: string;
        CustomerContactName?: string;
        CustomerContactTitle?: string;
        CustomerAddress?: string;
        CustomerCountry?: CustomerCountry;
        CustomerPhone?: string;
        CustomerFax?: string;
        CustomerEmail?: string;
        OrderDetailsList?: TblOrderDetailsRow[];
    }

    export namespace TblOrderRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'OrderId';
        export const localTextPrefix = 'SaleSystem.TblOrder';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            CustomerId = "CustomerId",
            OrderDate = "OrderDate",
            CustomerCompanyName = "CustomerCompanyName",
            CustomerContactName = "CustomerContactName",
            CustomerContactTitle = "CustomerContactTitle",
            CustomerAddress = "CustomerAddress",
            CustomerCountry = "CustomerCountry",
            CustomerPhone = "CustomerPhone",
            CustomerFax = "CustomerFax",
            CustomerEmail = "CustomerEmail",
            OrderDetailsList = "OrderDetailsList"
        }
    }
}
