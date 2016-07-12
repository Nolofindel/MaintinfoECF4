using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDalEntity;
namespace MaintinfoBll
{
    public class CatalogueManager
    {
        ArticleManager artMgr = new ArticleManager();
        public CatalogueManager() { }
        public void GenererCatalogue()
        {
            List<Article> arts = new List<Article>();
            try
            {
                
                arts = (List<Article>)artMgr.RecupererLesArticles();
                Catalogue.RemplirCatalogue(arts);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        public ICollection<Article> RecupererCatalogue()
        {
            return Catalogue.Instance.RecupererCatalogue();
        }
        public Article RechercheArticleById(int id)
        {
            return Catalogue.Instance.RecupererCatalogue().Find(p => p.ArticleID == id);
        }
        public void ViderCatalogue()
        {
            Catalogue.ViderCatalogue();
        }
    }
    //public class CatalogueManager
    //{
    //    Catalogue leCata;
    //    ArticleManager artMgr = new ArticleManager();

    //    public CatalogueManager() { }

    //    public ICollection<Article> RecupererCatalogue()
    //    {
    //        if (leCata == null)
    //        {
    //            leCata = new Catalogue() {LeCatalogue = (List<Article>)artMgr.RecupererLesArticles() };             
    //        }

    //        return leCata.LeCatalogue;
    //    }
    //    public void ViderCatalogue()
    //    {
    //        leCata.LeCatalogue = null;
    //    }
    //    public Article RechercheArticleById(int id)
    //    {
    //        return leCata.LeCatalogue.Find(p => p.ArticleID == id);
    //    }
    //}
}
