using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblCustomerRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblCustomerDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TblCustomerDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblCustomerDeleteHandler
    {
        public TblCustomerDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}