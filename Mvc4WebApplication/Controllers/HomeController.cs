using System.Web.Mvc;

namespace Mvc4WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Poets");
        }
    }
}
