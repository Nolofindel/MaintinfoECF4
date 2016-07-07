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
                ICollection<BonDeCommande> LesBdC = null;
                try
                {
                    var AllBonDeCommandes = db.BonDeCommandes;
                    foreach (BonDeCommande item in AllBonDeCommandes)
                    {
                        LesBdC.Add(item);
                    }
                    return LesBdC;
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
                    var LeBdc = db.BonDeCommandes.Find(id);
                    if (LeBdc == null)
                    {
                        throw new DaoExceptionAfficheMessage("Bon de commande inexistant");
                    }
                    return LeBdc;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Insert(BonDeCommande bdc)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(bdc).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(bdc.ArticleCommande).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Update(BonDeCommande bdc)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(bdc).State = EntityState.Modified;
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
