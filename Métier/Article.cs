using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintinfoBo
{
    public class Article
    {
        private int articleID;
        private string nomArticle;
        private int quantiteArticle;
        private int seuilMinimal;
        public Article Self { get { return this; } }
        public Article(int articleID, string nomArticle, int quantiteArticle, int seuilMinimal)
        {
            this.articleID = articleID;
            this.nomArticle = nomArticle;

            this.quantiteArticle = quantiteArticle;
            this.seuilMinimal = seuilMinimal;
        }

        public Article()
        {
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

        #region Override Methods
        // override ToString
        public override string ToString()
        {
            return NomArticle.ToString();
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            var article = obj as Article;
            if (article != null)
                return
                   article.ArticleID.Equals(this.ArticleID);
            else
                return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
