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
            Article art=ArticleDao.RecupererArticle(DesignationArticle);
            return art;

        }
        public void SortiArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;
            ArticleDao.MaJArticle(Article);
        }
        public void EntreeArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle += Quantite;
            ArticleDao.MaJArticle(Article);
        }
    }
}
