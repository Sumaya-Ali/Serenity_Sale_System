using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.ComponentModel;

namespace Serenity_Sale_System.Membership
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordRequest : ServiceRequest
    {
        [Required(true), EmailAddressEditor, DisplayName("E-mail Address")]
        public String Email { get; set; }
    }
}