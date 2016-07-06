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
    class BonDeCommandeEntityDao : IRepository<BonDeCommande>
    {
        public void Delete(BonDeCommande bdc)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.BonDeCommandes.Attach(bdc);
                    db.BonDeCommandes.Remove(bdc);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public ICollection<BonDeCommande> GetAll()
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

        public BonDeCommande GetById(object id)
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

        public void Insert(BonDeCommande obj)
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

        public void Update(BonDeCommande obj)
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
