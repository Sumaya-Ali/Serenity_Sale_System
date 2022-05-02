namespace Serenity_Sale_System.SaleSystem {
    export interface TblOrderForm {
        CustomerId: Serenity.LookupEditor;
        OrderDate: Serenity.DateEditor;
        OrderDetailsList: TblOrderDetailsEditor;
    }

    export class TblOrderForm extends Serenity.PrefixedContext {
        static formKey = 'SaleSystem.TblOrder';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TblOrderForm.init)  {
                TblOrderForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = TblOrderDetailsEditor;

                Q.initFormType(TblOrderForm, [
                    'CustomerId', w0,
                    'OrderDate', w1,
                    'OrderDetailsList', w2
                ]);
            }
        }
    }
}
