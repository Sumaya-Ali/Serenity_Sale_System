
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblOrderGrid extends Serenity.EntityGrid<TblOrderRow, any> {
        protected getColumnsKey() { return TblOrderColumns.columnsKey; }
        protected getDialogType() { return TblOrderDialog; }
        protected getIdProperty() { return TblOrderRow.idProperty; }
        protected getInsertPermission() { return TblOrderRow.insertPermission; }
        protected getLocalTextPrefix() { return TblOrderRow.localTextPrefix; }
        protected getService() { return TblOrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}