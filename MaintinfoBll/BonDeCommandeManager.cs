using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
using MaintinfoDalEntity;
using MaintinfoBll.Exceptions;
namespace MaintinfoBll
{
   public class BonDeCommandeManager
    {
        //son Irepository
        IRepository<BonDeCommande> bdcDao;

        #region Constructeur
        public BonDeCommandeManager()
        {

        }
        public BonDeCommandeManager(IRepository<BonDeCommande> repo)
        {
            bdcDao = repo;
        } 
        #endregion
        
        //Test si la quantité commandée est suffisante pour arriver au dessus du seuil
        public bool TesterQuantiteSeuil(BonDeCommande Bdc)
        {
            return (Bdc.QuantiteCommande + Bdc.ArticleCommande.QuantiteArticle >= Bdc.ArticleCommande.SeuilMinimal &Bdc.QuantiteCommande>0);
        }
        public void RemplirBonDeCommande(BonDeCommande Bdc,int Quantite)
        {
            Bdc.QuantiteCommande = Quantite;
        }
        public BonDeCommande CreerBonDeCommande(Article articleCommande, int quantiteCommande, DateTime dateCommande, bool commandeEffectue)
        {
            return  new BonDeCommande(articleCommande,quantiteCommande,dateCommande,commandeEffectue);
        }
        public void EnregistrerBonDeCommande(BonDeCommande bdc,bool Effectue)
        {
            bdc.CommandeEffectue = Effectue;
            bdcDao.Insert(bdc);
        }
        //Sert pour l'aperçu avant impression
        public string MiseEnPageBonDeCommande(BonDeCommande bdc)
        {
            string str= "Bon de Commande \n";
            str +=bdc.ArticleCommande.NomArticle.ToString()+"\n";
            str += bdc.ArticleCommande.DesignationArticle.ToString() + "\n";
            str +="Date de la Commande " + bdc.DateCommande.ToString() + "\n";
            str +="Quantité Commandé" + bdc.QuantiteCommande.ToString() + "\n";
            return str;
        }
        public void SuprimerBonDeCommande(BonDeCommande bdc)
        {
            bdcDao.Delete(bdc);
        }
        public void ModifierBonDeCommande(BonDeCommande bdc)
        {
            bdcDao.Update(bdc);
        }
        public BonDeCommande RechercherBonDeCommande(int id)
        {
            return bdcDao.GetById(id);
        }
        public ICollection<BonDeCommande> RecupererLesBonDeCommandes()
        {
            return bdcDao.GetAll();
        }
    }
}