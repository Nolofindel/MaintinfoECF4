using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;

namespace MaintinfoBll
{
    class BonEntreeManager
    {
        public static void CreerBonEntree(string refArt,int quantite)
        {
            Article art = ArticleManager.RechercheArticle(refArt);
            BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
            
        }
    }
}