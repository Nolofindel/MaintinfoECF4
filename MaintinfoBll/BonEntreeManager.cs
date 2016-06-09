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
        public virtual BonEntree CreerBonEntree(string refArt,int quantite)
        {
            Article art = new Article();
            ArticleManager artMan = new ArticleManager();
            ArticleDao rechArt = new ArticleDao();
            try
            {
                art = artMan.SaisirArticle(refArt);
                BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
                return BonE;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
        public virtual bool EnregistrerBonEntree(BonEntree t)
        {
            BonEntreeDao BEdao=new BonEntreeDao();
            ArticleManager artMan = new ArticleManager();
            try
            {                
                BEdao.Insert(t);
                artMan.EntrerArticle(t.ArticleEntree, t.QuantiteEntree);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}