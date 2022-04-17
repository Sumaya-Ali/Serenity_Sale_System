﻿using Serenity.Services;
using System;

namespace Serenity_Sale_System.Membership
{
    public class SignUpRequest : ServiceRequest
    {
        public String DisplayName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}