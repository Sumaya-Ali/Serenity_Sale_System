﻿using Newtonsoft.Json;
using Serenity.Services;
using System;
using System.Collections.Generic;

namespace Serenity_Sale_System.Administration
{
    public class RolePermissionUpdateRequest : ServiceRequest
    {
        public Int32? RoleID { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string Module { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string Submodule { get; set; }
        public List<string> Permissions { get; set; }
    }
}