
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblOrderDetailsDialog extends Serenity.EntityDialog<TblOrderDetailsRow, any> {
        protected getFormKey() { return TblOrderDetailsForm.formKey; }
        protected getIdProperty() { return TblOrderDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return TblOrderDetailsRow.localTextPrefix; }
        protected getService() { return TblOrderDetailsService.baseUrl; }
        protected getDeletePermission() { return TblOrderDetailsRow.deletePermission; }
        protected getInsertPermission() { return TblOrderDetailsRow.insertPermission; }
        protected getUpdatePermission() { return TblOrderDetailsRow.updatePermission; }

        protected form = new TblOrderDetailsForm(this.idPrefix);

    }
}