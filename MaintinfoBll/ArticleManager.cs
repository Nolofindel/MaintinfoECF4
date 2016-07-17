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

        #region Constructeur
        public ArticleManager()
        {
            artDao = new ArticleEntityDao();
        }
        public ArticleManager(IRepository<Article> repo)
        {
            artDao = repo;
        }
        #endregion

        #region Methodes
        public Article SaisirArticle(string DesignationArticle)
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
            try
            {
                if (Article.QuantiteArticle == 0 || Article.QuantiteArticle + Quantite <= 0)
                {
                    throw new BllExceptionAfficheMessage(Article.NomArticle + ": Quantité insuffisante restant ==> " + Article.QuantiteArticle);

                }
                else
                {
                    Article.QuantiteArticle -= Quantite;
                    artDao.Update(Article);
                }
            }
            catch (Exception ex)
            {

                throw new BllExceptionAfficheMessage(ex.Message);
            }

        }
        public void EntrerArticle(Article Article, int Quantite)
        {

            try
            {
                if (Article.QuantiteArticle == 0 || Article.QuantiteArticle + Quantite <= 0)
                {
                    throw new BllExceptionAfficheMessage(Article.NomArticle + ": Quantité insuffisante restant ==> " + Article.QuantiteArticle);
                }
                else
                {
                    Article.QuantiteArticle += Quantite;
                    artDao.Update(Article);
                    
                }
            }
            catch (Exception ex)
            {

                throw new BllExceptionAfficheMessage(ex.Message);
            }
  
        }

        public void SuprimerArticle(Article art)
        {
            artDao.Delete(art);
        }
        public void ModifierArticle(Article art)
        {
            artDao.Update(art);
        }

        public ICollection<Article> RecupererLesArticles()
        {
            return artDao.GetAll();
        } 
        #endregion
    }
}
