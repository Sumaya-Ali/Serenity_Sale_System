﻿using Microsoft.Data.SqlClient;
using Serenity.Data;
using Serenity.Services;
using System;

namespace Serenity_Sale_System
{
    public class HumanizeSqlExceptionBehavior : BaseSaveDeleteBehavior, IImplicitBehavior
    {
        public bool ActivateFor(IRow row)
        {
            return true;
        }

        public override void OnException(ISaveRequestHandler handler, Exception exception)
        {
            if (exception is SqlException)
                SqlExceptionHelper.HandleSavePrimaryKeyException(exception, handler.Context?.Localizer, 
                    handler.Row?.IdField?.GetTitle(handler.Context?.Localizer));
        }

        public override void OnException(IDeleteRequestHandler handler, Exception exception)
        {
            if (exception is SqlException)
                SqlExceptionHelper.HandleDeleteForeignKeyException(exception, handler.Context?.Localizer);
        }
    }
}
