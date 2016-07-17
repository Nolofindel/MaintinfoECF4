using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
using MaintinfoDalEntity;
using MaintinfoBll.Exceptions;

namespace MaintinfoBll
{
    public class BonSortieManager
    {
        IRepository<BonSortie> bsDao;
        ArticleManager artMgr = new ArticleManager();
        public BonSortieManager() { }
        public BonSortieManager(IRepository<BonSortie> repo)
        {
            bsDao = repo;
        }
        public BonSortie CreerBonSortie(Article art, Depanneur leDep,int quantite,DateTime date)
        {
            BonSortie BonS = new BonSortie(art,leDep, quantite,date);
            return BonS;
        }
        public bool EnregistrerBonSortie(BonSortie t)
        {
            try
            {                
                //met à jour la quantiter de l'article
                artMgr.SortirArticle(t.ArticleSortie, t.Quantite);
                //Si la MAJ de l'article est Ok creation du bon de sortie
                bsDao.Insert(t);
                return true;
            }
            catch (BllExceptionAfficheMessage ex)
            {

                throw new BllExceptionAfficheMessage(ex.Message, ex);
            }
        }

        public string MiseEnPageBonSortie(BonSortie BdS)
        {
            string str = "Bon de Sortie \n\n";
            str += "Nom du dépanneur: " + BdS.LeDepanneur.NomDepanneur + "\n\n";
            str += "Date de la demande: " + BdS.DateDemande.ToShortDateString() + "\n\n";
            str += "Désignation Article: " + BdS.ArticleSortie.NomArticle.ToString() + "\n\n";
            str += "Quantité demandée: " + BdS.Quantite.ToString() + "\n\n";
            return str;
        }

        public ICollection<Depanneur> lesDepanneurs()
        {
            DepanneurEntityDao depDao = new DepanneurEntityDao();
            return depDao.GetAll();
        }

        public void SuprimerBonSortie(BonSortie bs)
        {
            bsDao.Delete(bs);
        }
        public void ModifierBonSortie(BonSortie bs)
        {
            try
            {
                BonSortie oldBs = RechercherBonSortie(bs.BonSortieID);
                int diff = bs.Quantite - oldBs.Quantite;
                artMgr.SortirArticle(bs.ArticleSortie, diff);

                bsDao.Update(bs);
            }
            catch (BllExceptionAfficheMessage ex)
            {

                throw new BllExceptionAfficheMessage(ex.Message, ex);
            }
        }
        public BonSortie RechercherBonSortie( int id)
        {
            return bsDao.GetById(id);
        }
        public ICollection<BonSortie> RecupererLesBonSorties()
        {
            return bsDao.GetAll();
        }
    }
}