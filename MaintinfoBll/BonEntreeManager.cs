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
        public BonEntree CreerBonEntree(Article art,int quantite)
        {
                                 
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
                //met à jour la quantiter de l'article
                artMgr.EntrerArticle(t.ArticleEntree, t.QuantiteEntree);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        public void SuprimerBonEntree(BonEntree be)
        {
            beDao.Delete(be);
        }
        public void ModifierBonEntree(BonEntree be)
        {
            try
            {
                BonEntree oldBe = RechercherBonEntree(be.BonEntreeID);
                int diff = be.QuantiteEntree - oldBe.QuantiteEntree;
                artMgr.EntrerArticle(be.ArticleEntree, diff);

                beDao.Update(be);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
        public BonEntree RechercherBonEntree(int id)
        {
            return beDao.GetById(id);
        }
        public ICollection<BonEntree> RecupererLesBonEntrees()
        {
            return beDao.GetAll();
        }

    }
}