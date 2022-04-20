
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblCustomerGrid extends Serenity.EntityGrid<TblCustomerRow, any> {
        protected getColumnsKey() { return TblCustomerColumns.columnsKey; }
        protected getDialogType() { return TblCustomerDialog; }
        protected getIdProperty() { return TblCustomerRow.idProperty; }
        protected getInsertPermission() { return TblCustomerRow.insertPermission; }
        protected getLocalTextPrefix() { return TblCustomerRow.localTextPrefix; }
        protected getService() { return TblCustomerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}