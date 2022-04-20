using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity_Sale_System.SaleSystem.TblOrderDetailsRow>;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderDetailsRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderDetailsRetrieveHandler
    {
        public TblOrderDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}