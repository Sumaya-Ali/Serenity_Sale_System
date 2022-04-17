using Serenity.Services;

namespace Serenity_Sale_System.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}