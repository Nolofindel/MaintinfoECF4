using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDal;
namespace MaintinfoBll
{
    public class CatalogueManager
    {
        public static void GenererCatalogue(char cat)
        {
            List<Article> arts = new List<Article>();
            arts = CatalogueDao.RecupererArticleCategorie(cat);
            Catalogue.RemplirCatalogue(arts);
        }
        public static List<Article> RecupererCatalogue()
        {
            return Catalogue.Instance.RecupererCatalogue();
        }
        public static void ViderCatalogue()
        {

        }
    }
}
