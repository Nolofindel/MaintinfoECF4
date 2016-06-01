using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Article
    {
        private string designationArticle;
        private string nomArticle;
        private List<Article> sousEnsemble;

        public Article(string designationArticle, string nomArticle, int seuilMinimal, List<Article> sousEnsemble)
        {
            this.designationArticle = designationArticle;
            this.nomArticle = nomArticle;
            this.sousEnsemble = sousEnsemble;
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
    }
}
