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
        //Test si la quantité commandée est suffisante pour arriver au dessus du seuil
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
        //Sert pour l'aperçu avant impression
        public static string MiseEnPageBonDeCommande(BonDeCommande BdC)
        {
            string str= "Bon de Commande \n";
            str +=BdC.ArticleCommande.NomArticle.ToString()+"\n";
            str += BdC.ArticleCommande.DesignationArticle.ToString() + "\n";
            str +="Date de la Commande " + BdC.DateCommande.ToString() + "\n";
            str +="Quantité Commandé" + BdC.QuantiteCommande.ToString() + "\n";
            return str;
        }
    }
}