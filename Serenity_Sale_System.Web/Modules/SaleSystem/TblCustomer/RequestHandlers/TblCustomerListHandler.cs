using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity_Sale_System.SaleSystem.TblCustomerRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblCustomerRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblCustomerListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TblCustomerListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITblCustomerListHandler
    {
        public TblCustomerListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}