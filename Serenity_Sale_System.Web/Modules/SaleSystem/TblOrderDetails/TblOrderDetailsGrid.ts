
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblOrderDetailsGrid extends Serenity.EntityGrid<TblOrderDetailsRow, any> {
        protected getColumnsKey() { return TblOrderDetailsColumns.columnsKey; }
        protected getDialogType() { return TblOrderDetailsDialog; }
        protected getIdProperty() { return TblOrderDetailsRow.idProperty; }
        protected getInsertPermission() { return TblOrderDetailsRow.insertPermission; }
        protected getLocalTextPrefix() { return TblOrderDetailsRow.localTextPrefix; }
        protected getService() { return TblOrderDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}