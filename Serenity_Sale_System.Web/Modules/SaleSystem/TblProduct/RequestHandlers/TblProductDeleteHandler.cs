using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity_Sale_System.SaleSystem.TblProductRow;

namespace Serenity_Sale_System.SaleSystem
{
    public interface ITblProductDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TblProductDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITblProductDeleteHandler
    {
        public TblProductDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}