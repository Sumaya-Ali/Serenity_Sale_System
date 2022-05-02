namespace Serenity_Sale_System.SaleSystem {
    export interface TblOrderDetailsForm {
        ProductId: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
        UnitPrice: Serenity.IntegerEditor;
        Discount: Serenity.IntegerEditor;
        TotalPrice: Serenity.IntegerEditor;
    }

    export class TblOrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'SaleSystem.TblOrderDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TblOrderDetailsForm.init)  {
                TblOrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(TblOrderDetailsForm, [
                    'ProductId', w0,
                    'Quantity', w1,
                    'UnitPrice', w1,
                    'Discount', w1,
                    'TotalPrice', w1
                ]);
            }
        }
    }
}
