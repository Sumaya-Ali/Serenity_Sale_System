namespace Serenity_Sale_System.SaleSystem {
    export interface TblCustomerForm {
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Country: Serenity.EnumEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        Email: Serenity.StringEditor;
    }

    export class TblCustomerForm extends Serenity.PrefixedContext {
        static formKey = 'SaleSystem.TblCustomer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TblCustomerForm.init)  {
                TblCustomerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;

                Q.initFormType(TblCustomerForm, [
                    'CompanyName', w0,
                    'ContactName', w0,
                    'ContactTitle', w0,
                    'Address', w0,
                    'Country', w1,
                    'Phone', w0,
                    'Fax', w0,
                    'Email', w0
                ]);
            }
        }
    }
}
