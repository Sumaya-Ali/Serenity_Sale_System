using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity_Sale_System.SaleSystem.TblProductRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblProductRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblProductRetrieveHandler
    {
        public TblProductRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}