using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity_Sale_System.SaleSystem.TblOrderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderSaveHandler
    {
        public TblOrderSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}