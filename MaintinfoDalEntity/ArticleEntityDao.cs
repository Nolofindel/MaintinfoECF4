using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDalEntity.Configuration;
using MaintinfoDalEntity.Exceptions;
using System.Data.Entity;

namespace MaintinfoDalEntity
{
    class ArticleEntityDao : IRepository<Article>
    {
        public void Delete(Article art)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Articles.Attach(art);
                    db.Articles.Remove(art);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
            
        }

        public ICollection<Article> GetAll()
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                ICollection<Article> LesArt = null;
                try
                {
                    var AllArticles = db.Articles;
                    foreach (Article item in AllArticles)
                    {
                        LesArt.Add(item);
                    }
                    return LesArt;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }

        }
    

        public Article GetById(object id)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    var LArt = db.Articles.Find(id);
                    if (LArt == null)
                    {
                        throw new DaoExceptionAfficheMessage("Article inexistant");
                    }
                    return LArt;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }

    
        }

        public void Insert(Article art)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(art).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(art.SousEnsemble).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }


        }

        public void Update(Article art)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(art).State = EntityState.Modified;
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }

        }
        
    }
}
