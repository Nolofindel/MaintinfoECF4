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
        public static void EnregistrerBonDeCommande(BonDeCommande BdC)
        {
            BonDeCommandeDao BdCdao = new BonDeCommandeDao();
            BdCdao.Insert(BdC);
        }
        public static string MiseEnPageBonDeCommande(BonDeCommande BdC)
        {
            string str= "Bon de Commande \n";
            str +=BdC.ArticleCommande.NomArticle.ToString()+"\n";
            str +="Date de la Commande " + BdC.DateCommande.ToString() + "\n";
            str +="Quantité Commandé" + BdC.QuantiteCommande.ToString() + "\n";
            return str;
        }
    }
}