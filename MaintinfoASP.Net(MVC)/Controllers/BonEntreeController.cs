using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    public class BonEntreeController : Controller
    {
        // GET: BonEntree
        public ActionResult Index()
        {
            return View();
        }

        // GET: BonEntree/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonEntree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonEntree/Create
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

        // GET: BonEntree/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonEntree/Edit/5
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

        // GET: BonEntree/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonEntree/Delete/5
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
