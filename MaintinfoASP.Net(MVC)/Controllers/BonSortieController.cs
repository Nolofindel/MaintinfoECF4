using System;
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
        CatalogueManager ctrCata = new CatalogueManager();

        // GET: BonSortie
        public ActionResult Index()
        {
            ICollection<BonSortie> LesBs = ctrStock.RecupererLesBonSorties();
            return View(LesBs);
        }

        // GET: BonSortie/Details/5
        public ActionResult Details(int id)
        {
            BonSortie bs = ctrStock.RechercherBonSortie(id);
            return View(bs);
        }

        // GET: BonSortie/Create
        public ActionResult Create()
        {
            // charger les Depanneurs
            ICollection<Depanneur> lstDepanneurs = ctrStock.lesDepanneurs();
            TempData["lstDepanneurs"] = lstDepanneurs;
            ViewBag.lstDepanneurs = new SelectList(lstDepanneurs, "DepanneurID", "NomDepanneur");
            // charger les Articles
            ICollection<Article> lstArticles = ctrCata.RecupererCatalogue();
            TempData["lstArticles"] = lstArticles;
            ViewBag.lesArticles = new SelectList(lstArticles, "ArticleID", "NomArticle");
            return View();
        }

        // POST: BonSortie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    Article lArt = new Article();
                    lArt = ctrCata.RechercheArticleById(Convert.ToInt32(collection[""]));
                    Depanneur leDep = new Depanneur() {DepanneurID= Convert.ToInt32(collection[""]) };
                    BonSortie newBs = ctrStock.CreerBonSortie(lArt, leDep);
                    ctrStock.EnregistrerBonSortie(newBs);
                    
                }                
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
            // charger les Depanneurs
            ICollection<Depanneur> lstDepanneurs = ctrStock.lesDepanneurs();
            TempData["lstDepanneurs"] = lstDepanneurs;

            
            // charger les Articles
            ICollection<Article> lstArticles = ctrCata.RecupererCatalogue();
            TempData["lstArticles"] = lstArticles;
            BonSortie bs = ctrStock.RechercherBonSortie(id);
            ViewBag.lesDepanneurs = new SelectList(lstDepanneurs, "DepanneurID", "NomDepanneur",bs.DepanneurID);
            ViewBag.lesArticles = new SelectList(lstArticles, "ArticleID", "NomArticle",bs.ArticleID);

            return View(bs);
        }

        // POST: BonSortie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                BonSortie bs = new BonSortie()
                {
                    BonSortieID = id,
                    ArticleID = Convert.ToInt32(collection["ArticleSortie.ArticleID"]),
                    ArticleSortie = ctrCata.RechercheArticleById(Convert.ToInt32(collection["ArticleSortie.ArticleID"])),
                    Quantite = Convert.ToInt32(collection["Quantite"]),
                    DateDemande = Convert.ToDateTime(collection["DateDemande"])
                };
                ctrStock.ModifierBonSortie(bs);
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
