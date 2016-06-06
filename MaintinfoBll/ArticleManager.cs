using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDal;
namespace MaintinfoBll
{

    public class ArticleManager
    {


        public static List<Article> RechercherLesProduits(object o)
        {
            
            // Appel du Dao
            ArticleDao pDao = new ArticleDao();
            return pDao.FindAllBy(o);
        }

        public static  Article SaisirArticle(string DesignationArticle)
        {
            try {
            ArticleDao artdao = new ArticleDao();
            return artdao.GetById(DesignationArticle);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }
        public static void SortirArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;
            ArticleDao.MaJArticle(Article);
        }
        public static void EntrerArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle += Quantite;
            ArticleDao.MaJArticle(Article);
        }
    }
}
