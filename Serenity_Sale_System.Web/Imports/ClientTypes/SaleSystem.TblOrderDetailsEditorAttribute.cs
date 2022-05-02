using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity_Sale_System.SaleSystem
{
    public partial class TblOrderDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity_Sale_System.SaleSystem.TblOrderDetailsEditor";

        public TblOrderDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
