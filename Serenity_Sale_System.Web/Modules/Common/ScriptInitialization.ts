/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace Serenity_Sale_System.ScriptInitialization {

    /*
    export class UserLocalStorage implements Serenity.SettingStorage {
        getItem(key: string): string {
            return window.localStorage.getItem(
                Authorization.userDefinition.Username + ":" + key);
        }

        setItem(key: string, value: string): void {
            window.localStorage.setItem(
                Authorization.userDefinition.Username + ":" + key, value);
        }
    }
    */
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Serenity_Sale_System');
  //  Serenity.DataGrid.defaultPersistanceStorage = window.sessionStorage; //window.localStorage
 //   Serenity.DataGrid.defaultPersistanceStorage = new UserLocalStorage();
    Serenity.DataGrid.defaultPersistanceStorage = new Serenity.Extensions.UserPreferenceStorage();
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
    Serenity.HtmlContentEditor.CKEditorBasePath = "~/Serenity.Assets/Scripts/ckeditor/";

    if ($.fn['colorbox']) {
        $.fn['colorbox'].settings.maxWidth = "95%";
        $.fn['colorbox'].settings.maxHeight = "95%";
    }

    window.onerror = Q.ErrorHandling.runtimeErrorHandler;
}