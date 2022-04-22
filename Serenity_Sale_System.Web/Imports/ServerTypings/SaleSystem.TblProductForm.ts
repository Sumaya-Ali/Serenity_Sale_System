namespace Serenity_Sale_System.SaleSystem {
    export interface TblProductForm {
        ProductName: Serenity.StringEditor;
        ProductImage: Serenity.ImageUploadEditor;
        Category: Serenity.EnumEditor;
        Description: Serenity.TextAreaEditor;
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
                var w1 = s.ImageUploadEditor;
                var w2 = s.EnumEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(TblProductForm, [
                    'ProductName', w0,
                    'ProductImage', w1,
                    'Category', w2,
                    'Description', w3,
                    'Price', w0
                ]);
            }
        }
    }
}
