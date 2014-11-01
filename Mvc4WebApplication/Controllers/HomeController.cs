using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            logger.Info("Index called" + DateTime.Now);

            return View();
        }

        public ActionResult Index2()
        {
            logger.Info("Index2 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index3()
        {
            logger.Info("Index3 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index4()
        {
            logger.Info("Index4 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index5()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index6()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index7()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index8()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index9()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index10()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index11()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index12()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
        public ActionResult Index13()
        {
            logger.Info("Index5 called" + DateTime.Now);

            return View();
        }
    }
}
