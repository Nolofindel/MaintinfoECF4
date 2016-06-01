using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
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
