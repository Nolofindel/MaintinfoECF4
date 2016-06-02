using System;

namespace MaintinfoBo
{
    class BonDeCommande
    {
        private int numCommande;
        private DateTime dateCommande;
        private Article articleCommande;
        private int quantiteCommande;

        public BonDeCommande(Article articleCommande)
        {
            this.articleCommande = articleCommande;
            this.dateCommande = DateTime.Today;
        }

        public int NumCommande
        {
            get
            {
                return numCommande;
            }

            set
            {
                numCommande = value;
            }
        }

        public DateTime DateCommande
        {
            get
            {
                return dateCommande;
            }

            set
            {
                dateCommande = value;
            }
        }

        public Article ArticleCommande
        {
            get
            {
                return articleCommande;
            }

            set
            {
                articleCommande = value;
            }
        }

        public int QuantiteCommande
        {
            get
            {
                return quantiteCommande;
            }

            set
            {
                quantiteCommande = value;
            }
        }
    }
}
