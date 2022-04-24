
namespace Serenity_Sale_System.SaleSystem {
    import fld = TblCustomerRow.Fields;
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
        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const txt = (s) => 
                Q.text(`Db.${TblCustomerRow.localTextPrefix}.${s}`).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: fld.CompanyName, title: txt(fld.CompanyName) },
                { name: fld.ContactName, title: txt(fld.ContactName) },
                { name: fld.ContactTitle, title: txt(fld.ContactTitle) },
                { name: fld.Address, title: txt(fld.Address) },
                { name: fld.Phone, title: txt(fld.Phone) },
                { name: fld.Fax, title: txt(fld.Fax) },
                { name: fld.Email, title: txt(fld.Email) }
            ];
        }
    }
}