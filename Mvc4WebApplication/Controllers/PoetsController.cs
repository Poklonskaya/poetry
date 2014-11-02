using Poetry.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4WebApplication.Controllers
{
    public class PoetsController : Controller
    {
        List<Poet> poets;

        public PoetsController()
        {
            poets = new List<Poet>();

            poets.Add(new Poet
            {
                PoetId = 1,
                Name = "Пушкин"
            });

            poets.Add(new Poet
            {
                PoetId = 2,
                Name = "Есенин"
            });

            poets.Add(new Poet
            {
                PoetId = 3,
                Name = "Цветаева"
            });

            poets.Add(new Poet
            {
                PoetId = 4,
                Name = "Маяковский"
            });

            poets.Add(new Poet
            {
                PoetId = 5,
                Name = "Ахматова"
            });
        }

        //
        // GET: /Poets/

        public ActionResult Index()
        {  
            return View(poets);
        }

        //
        // GET: /Poets/Details/5

        public ActionResult Details(int id)
        {
            Poet poet = poets.FirstOrDefault(x => x.PoetId == id);

            return View(poet);
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
    }
}
