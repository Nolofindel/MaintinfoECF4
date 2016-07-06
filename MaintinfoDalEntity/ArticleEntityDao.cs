using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using MaintinfoDalEntity.Configuration;
using MaintinfoDalEntity.Exceptions;

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
                try
                {

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
                    var Lestag = db.Stagiaires.Find(id);
                    if (Lestag == null)
                    {
                        throw new DaoExceptionAfficheMessage("Stagiaire inexistant");
                    }
                    return Lestag;
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

                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }

        }
        
    }
}
