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
        public Article SaisirArticle(string DesignationArticle)
        {
            //Article art=ArticleDao.RecupererArticle(DesignationArticle);
            //return Article;
            return new Article();   ArticleDao add = new ArticleDao();        
        }
        public void SortiArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;

        }
    }
}
