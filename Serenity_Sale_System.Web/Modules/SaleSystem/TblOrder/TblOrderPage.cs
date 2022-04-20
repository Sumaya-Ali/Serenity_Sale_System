using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sale_System.SaleSystem.Pages
{

    [PageAuthorize(typeof(TblOrderRow))]
    public class TblOrderController : Controller
    {
        [Route("SaleSystem/TblOrder")]
        public ActionResult Index()
        {
            return View("~/Modules/SaleSystem/TblOrder/TblOrderIndex.cshtml");
        }
    }
}