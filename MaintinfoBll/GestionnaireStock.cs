using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoBll;
using MaintinfoDalEntity;

namespace MaintinfoBll
{
    public class GestionnaireStock
    {
        BonEntreeManager BeMgr;
        BonSortieManager BsMgr;
        BonDeCommandeManager BdCMgr;
        public GestionnaireStock()
        {
            BeMgr = new BonEntreeManager(new BonEntreeEntityDao());
            BsMgr = new BonSortieManager(new BonSortieEntityDao());
            BdCMgr = new BonDeCommandeManager(new BonDeCommandeEntityDao());
        }

        #region Bon d'entrée
        public BonEntree CreerBonEntree(Article art, int quantite)
        {
            return BeMgr.CreerBonEntree(art, quantite);
        }
        public bool EnregistrerBonEntree(BonEntree t)
        {
            return BeMgr.EnregistrerBonEntree(t);
        }
        public void SuprimerBonEntree(BonEntree be)
        {
            BeMgr.SuprimerBonEntree(be);
        }
        public void ModifierBonEntree(BonEntree be)
        {
            BeMgr.ModifierBonEntree(be);
        }
        public BonEntree RechercherBonEntree(int id)
        {
            return BeMgr.RechercherBonEntree(id);
        }
        public ICollection<BonEntree> RecupererLesBonEntrees()
        {
            return BeMgr.RecupererLesBonEntrees();
        }
        #endregion


        #region Bon de sortie
        public BonSortie CreerBonSortie(Article art, Depanneur leDep)
        {
            return BsMgr.CreerBonSortie(art,leDep);
        }
        public bool EnregistrerBonSortie(BonSortie t)
        {
            return BsMgr.EnregistrerBonSortie(t);
        }
        public string MiseEnPageBonSortie(BonSortie bdS)
        {
            return BsMgr.MiseEnPageBonSortie(bdS);
        }
        public ICollection<Depanneur> lesDepanneurs()
        {
            return BsMgr.lesDepanneurs();
        }
        public void SuprimerBonSortie(BonSortie bs)
        {
            BsMgr.SuprimerBonSortie(bs);
        }
        public void ModifierBonSortie(BonSortie bs)
        {
            BsMgr.ModifierBonSortie(bs);
        }
        public BonSortie RechercherBonSortie(int id)
        {
            return BsMgr.RechercherBonSortie(id);
        }
        public ICollection<BonSortie> RecupererLesBonSorties()
        {
            return BsMgr.RecupererLesBonSorties();
        }
        #endregion


        #region Bon de commande
        public bool TesterQuantiteSeuil(BonDeCommande bdc)
        {
            return BdCMgr.TesterQuantiteSeuil(bdc);
        }
        public void RemplirBonDeCommande(BonDeCommande bdc, int quantite)
        {
            BdCMgr.RemplirBonDeCommande(bdc, quantite);
        }
        public BonDeCommande CreerBonDeCommande(Article art)
        {
            return BdCMgr.CreerBonDeCommande(art);
        }
        public void EnregistrerBonDeCommande(BonDeCommande bdC, bool effectue)
        {
            BdCMgr.EnregistrerBonDeCommande(bdC, effectue);
            
        }
        public string MiseEnPageBonDeCommande(BonDeCommande bdC)
        {
            return BdCMgr.MiseEnPageBonDeCommande(bdC);
        }

        public void SuprimerBonDeCommande(BonDeCommande bdc)
        {
            BdCMgr.SuprimerBonDeCommande(bdc);
        }
        public void ModifierBonDeCommande(BonDeCommande bdc)
        {
            BdCMgr.ModifierBonDeCommande(bdc);
        }
        public BonDeCommande RechercherBonDeCommande(int id)
        {
            return BdCMgr.RechercherBonDeCommande(id);
        }
        public ICollection<BonDeCommande> RecupererLesBonDeCommandes()
        {
            return BdCMgr.RecupererLesBonDeCommandes();
        }

        #endregion
    }
}
