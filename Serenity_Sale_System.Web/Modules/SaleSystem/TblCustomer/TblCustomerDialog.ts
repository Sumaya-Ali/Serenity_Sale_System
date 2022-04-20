
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblCustomerDialog extends Serenity.EntityDialog<TblCustomerRow, any> {
        protected getFormKey() { return TblCustomerForm.formKey; }
        protected getIdProperty() { return TblCustomerRow.idProperty; }
        protected getLocalTextPrefix() { return TblCustomerRow.localTextPrefix; }
        protected getNameProperty() { return TblCustomerRow.nameProperty; }
        protected getService() { return TblCustomerService.baseUrl; }
        protected getDeletePermission() { return TblCustomerRow.deletePermission; }
        protected getInsertPermission() { return TblCustomerRow.insertPermission; }
        protected getUpdatePermission() { return TblCustomerRow.updatePermission; }

        protected form = new TblCustomerForm(this.idPrefix);

    }
}