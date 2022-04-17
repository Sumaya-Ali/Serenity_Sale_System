﻿using Serenity.ComponentModel;
using Serenity.Services;

namespace Serenity_Sale_System.Membership
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.Entities.UserRow), CheckNames = true)]
    public class LoginRequest : ServiceRequest
    {
        [Placeholder("user name")]
        public string Username { get; set; }
        [PasswordEditor, Required(true), Placeholder("password")]
        public string Password { get; set; }
    }
}