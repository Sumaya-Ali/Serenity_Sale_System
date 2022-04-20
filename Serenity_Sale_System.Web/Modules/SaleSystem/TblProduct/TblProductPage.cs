using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sale_System.SaleSystem.Pages
{

    [PageAuthorize(typeof(TblProductRow))]
    public class TblProductController : Controller
    {
        [Route("SaleSystem/TblProduct")]
        public ActionResult Index()
        {
            return View("~/Modules/SaleSystem/TblProduct/TblProductIndex.cshtml");
        }
    }
}