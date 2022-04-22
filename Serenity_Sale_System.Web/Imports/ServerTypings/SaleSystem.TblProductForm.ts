namespace Serenity_Sale_System.SaleSystem {
    export interface TblProductForm {
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.StringEditor;
        Category: Serenity.EnumEditor;
        Description: Serenity.StringEditor;
        Price: Serenity.StringEditor;
    }

    export class TblProductForm extends Serenity.PrefixedContext {
        static formKey = 'SaleSystem.TblProduct';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TblProductForm.init)  {
                TblProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;

                Q.initFormType(TblProductForm, [
                    'ProductName', w0,
                    'ProductImage', w0,
                    'Category', w1,
                    'Description', w0,
                    'Price', w0
                ]);
            }
        }
    }
}
