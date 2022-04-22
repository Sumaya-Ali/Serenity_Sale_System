namespace Serenity_Sale_System.SaleSystem {
    export interface TblCustomerForm {
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        Address: Serenity.TextAreaEditor;
        Country: Serenity.EnumEditor;
        Phone: Serenity.IntegerEditor;
        Fax: Serenity.IntegerEditor;
        Email: Serenity.EmailEditor;
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
                var w1 = s.TextAreaEditor;
                var w2 = s.EnumEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.EmailEditor;

                Q.initFormType(TblCustomerForm, [
                    'CompanyName', w0,
                    'ContactName', w0,
                    'ContactTitle', w0,
                    'Address', w1,
                    'Country', w2,
                    'Phone', w3,
                    'Fax', w3,
                    'Email', w4
                ]);
            }
        }
    }
}
