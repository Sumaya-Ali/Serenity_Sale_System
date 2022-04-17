using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity_Sale_System.Administration
{
    public partial class PermissionCheckEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity_Sale_System.Administration.PermissionCheckEditor";

        public PermissionCheckEditorAttribute()
            : base(Key)
        {
        }

        public bool ShowRevoke
        {
            get { return GetOption<bool>("showRevoke"); }
            set { SetOption("showRevoke", value); }
        }
    }
}
