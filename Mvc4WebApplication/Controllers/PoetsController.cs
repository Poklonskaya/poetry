﻿using Mvc4WebApplication.EntityFramework;
using Poetry.DomainModels;
using System.Collections.Generic;
using System.Linq;
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

            using (var db = new ApplicationDbContext("DefaultConnection"))
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

            using (var db = new ApplicationDbContext("DefaultConnection"))
            {
                poet = db.Poets.FirstOrDefault(x => x.PoetId == id);
            }

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
        public ActionResult Create(Poet poet)
        {
            try
            {
                using (var db = new ApplicationDbContext("DefaultConnection"))
                {
                    db.Poets.Add(poet);
                    db.SaveChanges();
                }

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
