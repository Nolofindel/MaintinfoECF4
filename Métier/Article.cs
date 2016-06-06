using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoBo
{
    public class Article
    {
        private string designationArticle;
        private string nomArticle;
        private List<Article> sousEnsemble;
        private int quantiteArticle;
        private int seuilMinimal;

        public Article(string designationArticle, string nomArticle, List<Article> sousEnsemble, int quantiteArticle, int seuilMinimal)
        {
            this.designationArticle = designationArticle;
            this.nomArticle = nomArticle;
            this.sousEnsemble = sousEnsemble;
            this.quantiteArticle = quantiteArticle;
            this.seuilMinimal = seuilMinimal;
        }

        public Article(string designationArticle, string nomArticle, int quantiteArticle, int seuilMinimal)
        {
            this.designationArticle = designationArticle;
            this.nomArticle = nomArticle;
            this.quantiteArticle = quantiteArticle;
            this.seuilMinimal = seuilMinimal;
        }

        public Article()
        {
        }
        // Equals : code identique
        public override bool Equals(Object obj)
        {
            var article = obj as Article;
            if (article != null)
                return
                   article.DesignationArticle.Equals(this.DesignationArticle);
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public string DesignationArticle
        {
            get
            {
                return designationArticle;
            }

            set
            {
                designationArticle = value;
            }
        }

        public string NomArticle
        {
            get
            {
                return nomArticle;
            }

            set
            {
                nomArticle = value;
            }
        }

        public List<Article> SousEnsemble
        {
            get
            {
                return sousEnsemble;
            }

            set
            {
                sousEnsemble = value;
            }
        }

        public int QuantiteArticle
        {
            get
            {
                return quantiteArticle;
            }

            set
            {
                quantiteArticle = value;
            }
        }

        public int SeuilMinimal
        {
            get
            {
                return seuilMinimal;
            }

            set
            {
                seuilMinimal = value;
            }
        }
    }
}
