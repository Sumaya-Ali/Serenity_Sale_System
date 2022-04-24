
namespace Serenity_Sale_System.SaleSystem {
    import fld = TblOrderRow.Fields;
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
        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const txt = (s) => 
                Q.text(`Db.${TblOrderRow.localTextPrefix}.${s}`).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: fld.OrderId, title: txt(fld.OrderId) },
                { name: fld.CustomerCompanyName, title: txt(fld.CustomerCompanyName) },
                { name: fld.CustomerContactName, title: txt(fld.CustomerContactName) },
                { name: fld.CustomerContactTitle, title: txt(fld.CustomerContactTitle) }
            ];
        }
    }
}