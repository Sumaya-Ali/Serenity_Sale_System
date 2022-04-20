using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity_Sale_System.SaleSystem.TblCustomerRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblCustomerRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblCustomerSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TblCustomerSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITblCustomerSaveHandler
    {
        public TblCustomerSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}