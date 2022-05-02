namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblOrderDetailsEditDialog extends
        Serenity.Extensions.GridEditorDialog<TblOrderDetailsRow> {
        protected getFormKey() { return TblOrderDetailsForm.formKey; }
        protected getNameProperty() { return TblOrderDetailsRow.nameProperty; }
        protected getLocalTextPrefix() { return TblOrderDetailsRow.localTextPrefix; }

        protected form: TblOrderDetailsForm;

        constructor() {
            super();
            this.form = new TblOrderDetailsForm(this.idPrefix);
        }
    }
}