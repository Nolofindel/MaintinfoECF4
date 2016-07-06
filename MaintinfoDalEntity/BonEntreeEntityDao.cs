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
    class BonEntreeEntityDao : IRepository<BonEntree>
    {
        public void Delete(BonEntree be)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.BonEntrees.Attach(be);
                    db.BonEntrees.Remove(be);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public ICollection<BonEntree> GetAll()
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

        public BonEntree GetById(object id)
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

        public void Insert(BonEntree obj)
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

        public void Update(BonEntree obj)
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
