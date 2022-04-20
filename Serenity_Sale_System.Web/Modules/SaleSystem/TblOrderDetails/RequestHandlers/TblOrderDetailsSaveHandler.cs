using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity_Sale_System.SaleSystem.TblOrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderDetailsRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderDetailsSaveHandler
    {
        public TblOrderDetailsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}