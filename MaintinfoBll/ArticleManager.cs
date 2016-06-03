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


        public List<Article> RechercherLesProduits(object o)
        {
            
            // Appel du Dao
            ArticleDao pDao = new ArticleDao();
            return pDao.FindAllBy(o);
        }

        public Article SaisirArticle(string DesignationArticle)
        {
            Article art=ArticleDao.RecupererArticle(DesignationArticle);
            return art;

        }
        public void SortirArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;
            ArticleDao.MaJArticle(Article);
        }
        public void EntrerArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle += Quantite;
            ArticleDao.MaJArticle(Article);
        }
    }
}
