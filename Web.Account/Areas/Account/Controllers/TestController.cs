using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Account.Areas.Account.Controllers
{
    [Area("Account")]
    public class TestController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }
    }
}
