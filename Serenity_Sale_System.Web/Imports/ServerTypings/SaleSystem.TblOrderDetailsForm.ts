namespace Serenity_Sale_System.SaleSystem {
    export interface TblOrderDetailsForm {
        OrderId: Serenity.IntegerEditor;
        ProductId: Serenity.IntegerEditor;
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
                var w0 = s.IntegerEditor;

                Q.initFormType(TblOrderDetailsForm, [
                    'OrderId', w0,
                    'ProductId', w0,
                    'Quantity', w0,
                    'UnitPrice', w0,
                    'Discount', w0,
                    'TotalPrice', w0
                ]);
            }
        }
    }
}
