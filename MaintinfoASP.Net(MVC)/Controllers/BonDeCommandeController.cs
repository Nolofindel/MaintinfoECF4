using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    public class BonDeCommandeController : Controller
    {
        // GET: BonDeCommande
        public ActionResult Index()
        {
            return View();
        }

        // GET: BonDeCommande/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonDeCommande/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonDeCommande/Create
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

        // GET: BonDeCommande/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonDeCommande/Edit/5
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

        // GET: BonDeCommande/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonDeCommande/Delete/5
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
