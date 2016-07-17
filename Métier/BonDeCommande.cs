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
            
        }
        public BonDeCommande(Article articleCommande, int quantiteCommande, DateTime dateCommande, bool commandeEffectue)
        {
            this.articleCommande = articleCommande;
            this.articleID = articleCommande.ArticleID;
            this.quantiteCommande = quantiteCommande;
            this.commandeEffectue = commandeEffectue;
            if (dateCommande == null)
                this.dateCommande = DateTime.Today.Date;
            else
                this.dateCommande = dateCommande.Date;            
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
