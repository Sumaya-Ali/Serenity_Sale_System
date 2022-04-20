using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderDeleteHandler
    {
        public TblOrderDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}