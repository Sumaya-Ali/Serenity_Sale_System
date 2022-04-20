using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity_Sale_System.SaleSystem.TblProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblProductRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblProductSaveHandler
    {
        public TblProductSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}