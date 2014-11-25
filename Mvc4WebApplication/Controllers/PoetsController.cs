using Mvc4WebApplication.EntityFramework;
using Poetry.DomainModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4WebApplication.Controllers
{
    public class PoetsController : Controller
    {
        //
        // GET: /Poets/

        public ActionResult Index()
        {
            List<Poet> poets;

            using (ApplicationDbContext db = new ApplicationDbContext("DefaultConnection"))
            {
                poets = db.Poets.ToList();
            }

            return View(poets);
        }

        //
        // GET: /Poets/Details/5

        public ActionResult Details(int id)
        {
            Poet poet;

            using (ApplicationDbContext db = new ApplicationDbContext("DefaultConnection"))
            {
                poet = db.Poets.FirstOrDefault(x => x.PoetId == id);
            }

            return View(poet);
        }



        class POETS
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

     var po = context.Poets.ToList();
            foreach (var PoetId in Poetry.DomainModels.Poet)
            {
                Console.WriteLine("{0} {1} {2}", PoetID, Name, AvatarUrl);
            }
            Console.ReadLine();


             var newPoet = new Poet
            {    
                Name = "ссылка",
                AvatarUrl=http://localhost:1640/Images/a.jpg
            };
            context.Poets.InsertOnSubmit(newPoet);
            context.Poets.Context.SubmitChanges();
        }
    }




       




        //
        // GET: /Poets/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Poets/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poets/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Poets/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Poets/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Poets/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    
public  string http { get; set; }}
}
