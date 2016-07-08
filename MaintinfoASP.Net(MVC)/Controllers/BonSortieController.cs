﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaintinfoBll;
using MaintinfoBo;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    public class BonSortieController : Controller
    {
        // GET: Gestionnaire stock
        GestionnaireStock ctrStock = new GestionnaireStock();
        // GET: BonSortie
        public ActionResult Index()
        {
            ICollection<BonSortie> LesBs = ctrStock.RecupererLesBonSorties();
            return View(LesBs);
        }

        // GET: BonSortie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonSortie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonSortie/Create
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

        // GET: BonSortie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonSortie/Edit/5
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

        // GET: BonSortie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonSortie/Delete/5
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
