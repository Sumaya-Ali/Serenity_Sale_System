
namespace Serenity_Sale_System.SaleSystem {
    import fld = TblProductRow.Fields;
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

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const txt = (s) => 
                Q.text(`Db.${TblProductRow.localTextPrefix}.${s}`).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: fld.ProductName, title: txt(fld.ProductName) },
                { name: fld.Description, title: txt(fld.Description) },
                { name: fld.Price, title: txt(fld.Price) }
            ];
        }
    }
}