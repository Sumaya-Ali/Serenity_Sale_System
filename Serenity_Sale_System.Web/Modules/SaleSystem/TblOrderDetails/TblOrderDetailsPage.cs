using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sale_System.SaleSystem.Pages
{

    [PageAuthorize(typeof(TblOrderDetailsRow))]
    public class TblOrderDetailsController : Controller
    {
        [Route("SaleSystem/TblOrderDetails")]
        public ActionResult Index()
        {
            return View("~/Modules/SaleSystem/TblOrderDetails/TblOrderDetailsIndex.cshtml");
        }
    }
}