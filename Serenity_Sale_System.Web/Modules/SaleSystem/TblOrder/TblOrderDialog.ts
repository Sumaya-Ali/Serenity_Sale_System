
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblOrderDialog extends Serenity.EntityDialog<TblOrderRow, any> {
        protected getFormKey() { return TblOrderForm.formKey; }
        protected getIdProperty() { return TblOrderRow.idProperty; }
        protected getLocalTextPrefix() { return TblOrderRow.localTextPrefix; }
        protected getService() { return TblOrderService.baseUrl; }
        protected getDeletePermission() { return TblOrderRow.deletePermission; }
        protected getInsertPermission() { return TblOrderRow.insertPermission; }
        protected getUpdatePermission() { return TblOrderRow.updatePermission; }

        protected form = new TblOrderForm(this.idPrefix);

    }
}