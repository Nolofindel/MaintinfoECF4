using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
namespace MaintinfoBll
{
   public class BonDeCommandeManager
    {
        public bool TesterQuantiteSeuil(BonDeCommande Bdc)
        {
            return Bdc.QuantiteCommande + Bdc.ArticleCommande.QuantiteArticle >= Bdc.ArticleCommande.SeuilMinimal;
        }
        public void RemplirBonDeCommande(BonDeCommande Bdc,int Quantite)
        {
            Bdc.QuantiteCommande = Quantite;
        }
    }
}