using MaintinfoBll;
using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    public class BonDeCommandeController : Controller
    {
        // GET: Gestionnaire stock
        GestionnaireStock ctrStock = new GestionnaireStock();
        CatalogueManager ctrCata = new CatalogueManager();

        // GET: BonDeCommande
        public ActionResult Index()
        {
            ICollection<BonDeCommande> LesBdC = ctrStock.RecupererLesBonDeCommandes();
            return View(LesBdC);            
        }

        // GET: BonDeCommande/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonDeCommande/Create
        public ActionResult Create()
        {
            // charger les Articles
            ICollection<Article> lstArticles = ctrCata.RecupererCatalogue();
            TempData["lstArticles"] = lstArticles;
            ViewBag.lstArticles = new SelectList(lstArticles, "ArticleID", "NomArticle");

            return View();
        }

        // POST: BonDeCommande/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    Article lArt = new Article();
                    lArt = ctrCata.RechercheArticleById(Convert.ToInt32(collection["ArticleID"]));
                    BonDeCommande newBdC = ctrStock.CreerBonDeCommande(lArt);
                    
                    ctrStock.EnregistrerBonDeCommande(newBdC, Convert.ToBoolean(collection["CommandeEffectue"]));
                    //return View("Merci");
                }
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
