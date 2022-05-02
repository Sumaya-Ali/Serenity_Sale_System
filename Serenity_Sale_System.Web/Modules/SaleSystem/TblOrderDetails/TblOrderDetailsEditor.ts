namespace Serenity_Sale_System.SaleSystem {
    @Serenity.Decorators.registerEditor()
    export class TblOrderDetailsEditor
        extends Serenity.Extensions.GridEditorBase<TblOrderDetailsRow> {
        protected getColumnsKey() { return "SaleSystem.TblOrderDetails"; }
        protected getLocalTextPrefix() { return TblOrderDetailsRow.localTextPrefix; }
        protected getDialogType() { return TblOrderDetailsEditDialog; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getAddButtonCaption() {
            return "Add";
        }
        protected validateEntity(row: TblOrderDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;        

            row.ProductProductName = TblProductRow.getLookup()
                .itemById[row.ProductId].ProductName;

            return true;
        }
    }
} 