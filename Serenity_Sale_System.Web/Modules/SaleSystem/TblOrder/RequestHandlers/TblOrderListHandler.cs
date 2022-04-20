using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity_Sale_System.SaleSystem.TblOrderRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderListHandler
    {
        public TblOrderListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}