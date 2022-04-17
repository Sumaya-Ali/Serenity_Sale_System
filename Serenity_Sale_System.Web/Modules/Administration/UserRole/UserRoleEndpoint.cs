using Serenity.Data;
using Serenity.Services;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MyRepository = Serenity_Sale_System.Administration.Repositories.UserRoleRepository;
using MyRow = Serenity_Sale_System.Administration.Entities.UserRoleRow;

namespace Serenity_Sale_System.Administration.Endpoints
{
    [Route("Services/Administration/UserRole/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserRoleController : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
        {
            return new MyRepository(Context).Update(uow, request);
        }

        public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
        {
            return new MyRepository(Context).List(connection, request);
        }
    }
}
