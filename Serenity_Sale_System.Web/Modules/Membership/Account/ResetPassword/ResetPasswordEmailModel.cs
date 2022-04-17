
namespace Serenity_Sale_System.Membership
{
    public class ResetPasswordEmailModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string ResetLink { get; set; }
    }
}