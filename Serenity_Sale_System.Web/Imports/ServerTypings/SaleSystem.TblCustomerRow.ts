﻿namespace Serenity_Sale_System.SaleSystem {
    export interface TblCustomerRow {
        CustomerId?: number;
        CompanyName?: string;
        ContactName?: string;
        ContactTitle?: string;
        Address?: string;
        Country?: number;
        Phone?: string;
        Fax?: string;
        Email?: string;
    }

    export namespace TblCustomerRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'CompanyName';
        export const localTextPrefix = 'SaleSystem.TblCustomer';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            CompanyName = "CompanyName",
            ContactName = "ContactName",
            ContactTitle = "ContactTitle",
            Address = "Address",
            Country = "Country",
            Phone = "Phone",
            Fax = "Fax",
            Email = "Email"
        }
    }
}