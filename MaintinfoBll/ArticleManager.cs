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

        public virtual  Article SaisirArticle(string DesignationArticle)
        {
            try {
            ArticleDao artDao = new ArticleDao();
            return artDao.GetById(DesignationArticle);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }
        public virtual void SortirArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;
            
        }
        public virtual void EntrerArticle(Article Article, int Quantite)
        { ArticleDao artDao = new ArticleDao();
            Article.QuantiteArticle += Quantite;
            artDao.Update(Article);
            
        }
    }
}
