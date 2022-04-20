using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sale_System.SaleSystem.Pages
{

    [PageAuthorize(typeof(TblCustomerRow))]
    public class TblCustomerController : Controller
    {
        [Route("SaleSystem/TblCustomer")]
        public ActionResult Index()
        {
            return View("~/Modules/SaleSystem/TblCustomer/TblCustomerIndex.cshtml");
        }
    }
}