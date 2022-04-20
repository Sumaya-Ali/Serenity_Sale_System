
namespace Serenity_Sale_System.SaleSystem {

    @Serenity.Decorators.registerClass()
    export class TblProductGrid extends Serenity.EntityGrid<TblProductRow, any> {
        protected getColumnsKey() { return TblProductColumns.columnsKey; }
        protected getDialogType() { return TblProductDialog; }
        protected getIdProperty() { return TblProductRow.idProperty; }
        protected getInsertPermission() { return TblProductRow.insertPermission; }
        protected getLocalTextPrefix() { return TblProductRow.localTextPrefix; }
        protected getService() { return TblProductService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}