
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblProductDialog extends Serenity.EntityDialog<TblProductRow, any> {
        protected getFormKey() { return TblProductForm.formKey; }
        protected getIdProperty() { return TblProductRow.idProperty; }
        protected getLocalTextPrefix() { return TblProductRow.localTextPrefix; }
        protected getNameProperty() { return TblProductRow.nameProperty; }
        protected getService() { return TblProductService.baseUrl; }
        protected getDeletePermission() { return TblProductRow.deletePermission; }
        protected getInsertPermission() { return TblProductRow.insertPermission; }
        protected getUpdatePermission() { return TblProductRow.updatePermission; }

        protected form = new TblProductForm(this.idPrefix);

    }
}