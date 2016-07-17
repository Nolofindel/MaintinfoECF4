﻿using System;

namespace MaintinfoBo
{
    public class BonSortie
    {
        private int bonSortieID;
        private Depanneur leDepanneur;
        private int depanneurID;
        private Article articleSortie;
        private int articleID;
        private int quantiteSortie;
        private DateTime dateDemande;

        public BonSortie()
        {
            
        }
        public BonSortie(Article articleSortie, Depanneur leDepanneur, int quantite, DateTime dateDemande)
        {
            this.leDepanneur = leDepanneur;
            this.depanneurID = leDepanneur.DepanneurID;
            this.articleSortie = articleSortie;
            this.articleID = articleSortie.ArticleID;
            this.quantiteSortie = quantite;

            if (dateDemande == null)
                this.dateDemande = DateTime.Today;
            else
                this.dateDemande = dateDemande.Date;


        }
        public int BonSortieID
        {
            get
            {
                return bonSortieID;
            }
            set
            {
                bonSortieID = value;
            }
        }
        public Depanneur LeDepanneur
        {
            get
            {
                return leDepanneur;
            }

            set
            {
                leDepanneur = value;
            }
        }
        public int DepanneurID
        {
            get
            {
                return depanneurID;
            }

            set
            {
                depanneurID = value;
            }
        }
        public Article ArticleSortie
        {
            get
            {
                return articleSortie;
            }

            set
            {
                articleSortie = value;
            }
        }
        public int ArticleID
        {
            get
            {
                return articleID;
            }

            set
            {
                articleID = value;
            }
        }
        public int Quantite
        {
            get
            {
                return quantiteSortie;
            }

            set
            {
                quantiteSortie = value;
            }
        }

        public DateTime DateDemande
        {
            get
            {
                return dateDemande;
            }

            set
            {
                dateDemande = value;
            }
        }
    }
}
