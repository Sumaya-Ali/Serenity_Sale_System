using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity_Sale_System.SaleSystem.TblProductRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblProductRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TblProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblProductListHandler
    {
        public TblProductListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}