using MaintinfoBll;
using MaintinfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    public class BonEntreeController : Controller
    {
        // GET: Gestionnaire stock
        GestionnaireStock ctrStock = new GestionnaireStock();
        CatalogueManager ctrCata = new CatalogueManager();

        // GET: BonEntree
        public ActionResult Index()
        {
            ICollection<BonEntree> LesBe = ctrStock.RecupererLesBonEntrees();
            return View(LesBe);
            
        }

        // GET: BonEntree/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonEntree/Create
        public ActionResult Create()
        {            
            // charger les Articles
            ICollection<Article> lstArticles = ctrCata.RecupererCatalogue();
            TempData["lstArticles"] = lstArticles;
            ViewBag.lesArticles = new SelectList(lstArticles, "ArticleID", "NomArticle");

            return View();
        }

        // POST: BonEntree/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    Article lArt = new Article();
                    lArt = ctrCata.RechercheArticleById(Convert.ToInt32(collection["ArticleEntree.ArticleID"]));
                    BonEntree newBe = ctrStock.CreerBonEntree(lArt,Convert.ToInt32(collection["QuantiteEntree"]));
                    ctrStock.EnregistrerBonEntree(newBe);
                    //return View("Merci");
                }
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
            // charger les Articles
            ICollection<Article> lstArticles = ctrCata.RecupererCatalogue();
            TempData["lstArticles"] = lstArticles;

            BonEntree be = ctrStock.RechercherBonEntree(id);
            ViewBag.lesArticles = new SelectList(lstArticles, "ArticleID", "NomArticle",be.ArticleID);

       
            return View(be);
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
