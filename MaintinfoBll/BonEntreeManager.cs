using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;
using MaintinfoDal;

namespace MaintinfoBll
{
    public class BonEntreeManager
    {
        public static BonEntree CreerBonEntree(string refArt,int quantite)
        {
            Article art = new Article();
            ArticleDao rechArt = new ArticleDao();
            art = rechArt.GetById(refArt);
            BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
            return BonE;
        }
        public static bool EnregistrerBonEntree(BonEntree t)
        {
            BonEntreeDao BEdao=new BonEntreeDao();
            BEdao.Insert(t);
            return true;
        }
    }
}