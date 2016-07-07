using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
using MaintinfoDalEntity;
using MaintinfoBll.Exceptions;

namespace MaintinfoBll
{
    public class BonEntreeManager
    {
        //son Irepository
        IRepository<BonEntree> beDao;
        ArticleManager artMgr = new ArticleManager();
        public BonEntreeManager()
        {

        }
        public BonEntreeManager(IRepository<BonEntree> repo)
        {
            beDao = repo;
        }
        public BonEntree CreerBonEntree(string refArt,int quantite)
        {
            Article art = new Article();                        
            try
            {               
                BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
                return BonE;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
        public bool EnregistrerBonEntree(BonEntree t)
        {         

            try
            {
                beDao.Insert(t);
                artMgr.EntrerArticle(t.ArticleEntree, t.QuantiteEntree);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}