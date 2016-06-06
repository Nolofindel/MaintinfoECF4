using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
using MaintinfoDal;
namespace MaintinfoBll
{
   public class BonDeCommandeManager
    {
        public static  bool TesterQuantiteSeuil(BonDeCommande Bdc)
        {
            return Bdc.QuantiteCommande + Bdc.ArticleCommande.QuantiteArticle >= Bdc.ArticleCommande.SeuilMinimal;
        }
        public void RemplirBonDeCommande(BonDeCommande Bdc,int Quantite)
        {
            Bdc.QuantiteCommande = Quantite;
        }
        public static BonDeCommande CreerBonDeCommande(Article art)
        {
            return  new BonDeCommande(art);
        }
        public void EnregistrerBonDeCommande(BonDeCommande BdC)
        {
            BonDeCommandeDao.EnregistrerBonDeCommande(BdC);
        }
    }
}