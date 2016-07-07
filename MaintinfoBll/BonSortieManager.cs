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
        public BonSortieManager() { }
        public BonSortieManager(IRepository<BonSortie> repo)
        {
            bsDao = repo;
        }
        public BonSortie CreerBonSortie(Article art)
        {
            return new BonSortie(art);
        }

        public string MiseEnPageBonSortie(BonSortie BdS)
        {
            string str = "Bon de Sortie \n\n";
            str += "Nom du dépanneur: " + BdS.NomDepanneur + "\n\n";
            str += "Date de la demande: " + BdS.DateDemande.ToShortDateString() + "\n\n";
            str += "Désignation Article: " + BdS.ArticleSortie.NomArticle.ToString() + "\n\n";
            str += "Quantité demandée: " + BdS.Quantite.ToString() + "\n\n";
            return str;
        }

        public List<Depanneur> lesDepanneurs()
        {
            DepanneurDao depDao = new DepanneurDao();
            return depDao.GetAll();
        }


    }
}