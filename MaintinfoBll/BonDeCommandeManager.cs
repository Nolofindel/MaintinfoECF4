﻿using System;
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
       public BonDeCommandeManager(IRepository<BonDeCommande> repo)
        {
            bdcDao = repo;
        }
        //Test si la quantité commandée est suffisante pour arriver au dessus du seuil
        public bool TesterQuantiteSeuil(BonDeCommande Bdc)
        {
            return (Bdc.QuantiteCommande + Bdc.ArticleCommande.QuantiteArticle >= Bdc.ArticleCommande.SeuilMinimal &Bdc.QuantiteCommande>0);
        }
        public void RemplirBonDeCommande(BonDeCommande Bdc,int Quantite)
        {
            Bdc.QuantiteCommande = Quantite;
        }
        public BonDeCommande CreerBonDeCommande(Article art)
        {
            return  new BonDeCommande(art);
        }
        public void EnregistrerBonDeCommande(BonDeCommande BdC,bool Effectue)
        {
            BdC.CommandeEffectue = Effectue;
            bdcDao.Insert(BdC);
        }
        //Sert pour l'aperçu avant impression
        public string MiseEnPageBonDeCommande(BonDeCommande BdC)
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