using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblOrderDetailsRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblOrderDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TblOrderDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblOrderDetailsDeleteHandler
    {
        public TblOrderDetailsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}