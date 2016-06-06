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
            try
            {
                ArticleDao cDao = new ArticleDao();
                arts = cDao.FindAllBy(cat);
                Catalogue.RemplirCatalogue(arts);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
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
