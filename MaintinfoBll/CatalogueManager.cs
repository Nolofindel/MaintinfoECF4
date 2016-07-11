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
        Catalogue leCata = new Catalogue();
        ArticleManager artMgr = new ArticleManager();

        public CatalogueManager() { }

        public ICollection<Article> RecupererCatalogue()
        {
            leCata.LeCatalogue = (List<Article>)artMgr.RecupererLesArticles();
            return leCata.LeCatalogue;
        }
        public void ViderCatalogue()
        {
            leCata.LeCatalogue = null;
        }
    }
}
