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
        public BonSortie CreerBonSortie(Article art, Depanneur leDep)
        {
            BonSortie BonS = new BonSortie(art,leDep);
            return BonS;
        }
        public bool EnregistrerBonSortie(BonSortie t)
        {

            try
            {
                bsDao.Insert(t);
                //met à jour la quantiter de l'article
                artMgr.SortirArticle(t.ArticleSortie, t.Quantite);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
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
            bsDao.Update(bs);
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