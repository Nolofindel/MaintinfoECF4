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
            try
            {
                art = ArticleManager.SaisirArticle(refArt);
                BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
                return BonE;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
        public static bool EnregistrerBonEntree(BonEntree t)
        {
            BonEntreeDao BEdao=new BonEntreeDao();

            try
            {                
                BEdao.Insert(t);
                ArticleManager.EntrerArticle(t.ArticleEntree, t.QuantiteEntree);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}