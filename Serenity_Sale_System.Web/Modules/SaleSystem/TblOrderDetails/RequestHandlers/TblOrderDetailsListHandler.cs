using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity_Sale_System.SaleSystem.TblOrderDetailsRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderDetailsRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderDetailsListHandler
    {
        public TblOrderDetailsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}