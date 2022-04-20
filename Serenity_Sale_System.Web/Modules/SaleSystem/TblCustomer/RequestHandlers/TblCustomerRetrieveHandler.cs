using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity_Sale_System.SaleSystem.TblCustomerRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblCustomerRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblCustomerRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblCustomerRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblCustomerRetrieveHandler
    {
        public TblCustomerRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}