using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity_Sale_System.SaleSystem.TblOrderRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderRetrieveHandler
    {
        public TblOrderRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}