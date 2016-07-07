using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDalEntity;
using MaintinfoBll.Exceptions;

namespace MaintinfoBll
{

    public class ArticleManager
    {
        //Son Irepository
        IRepository<Article> artDao;
        public ArticleManager()
        {

        }
        public ArticleManager(IRepository<Article> repo)
        {
            artDao = repo;
        }
        public  Article SaisirArticle(string DesignationArticle)
        {
            try
            {
                return artDao.GetById(DesignationArticle);
            }
            catch (BllExceptionAfficheMessage e)
            {
                throw new BllExceptionAfficheMessage(e.Message, e);
            }

        }
        public void SortirArticle(Article Article, int Quantite)
        {
            Article.QuantiteArticle -= Quantite;
            
        }
        public  void EntrerArticle(Article Article, int Quantite)
        {            
            Article.QuantiteArticle += Quantite ;
            artDao.Update(Article);            
        }
    }
}
