using System;

namespace MaintinfoBo
{
    public class BonDeCommande
    {
        private int bonDeCommandeID;
        private DateTime dateCommande;
        private Article articleCommande;
        private int articleID;
        private int quantiteCommande;
        private bool commandeEffectue;

        public BonDeCommande()
        {
            this.dateCommande = DateTime.Now;
        }
        public BonDeCommande(Article articleCommande)
        {
            this.articleCommande = articleCommande;
            this.dateCommande = DateTime.Now;
        }
        public int BonDeCommandeID
        {
            get
            {
                return bonDeCommandeID;
            }
            set
            {
                bonDeCommandeID = value;
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

        public bool CommandeEffectue
        {
            get
            {
                return commandeEffectue;
            }

            set
            {
                commandeEffectue = value;
            }
        }
    }
}
