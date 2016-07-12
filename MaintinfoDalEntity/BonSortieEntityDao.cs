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
    public class BonSortieEntityDao : IRepository<BonSortie>
    {
        public void Delete(BonSortie bs)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.BonSorties.Attach(bs);
                    db.BonSorties.Remove(bs);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Erreur : " + Dex.Message);
                }
            }
        }

        public ICollection<BonSortie> GetAll()
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                //ICollection<BonSortie> LesBs = null;
                try
                {
                    var bs = db.BonSorties.Include(p => p.ArticleSortie).ToList();
                    return bs;
                    //var AllBonSorties = db.BonSorties;
                    //foreach (BonSortie item in AllBonSorties)
                    //{
                    //    LesBs.Add(item);
                    //}
                    //return LesBs;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public BonSortie GetById(object id)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    var LeBonSortie = db.BonSorties.Find(id);
                    if (LeBonSortie == null)
                    {
                        throw new DaoExceptionAfficheMessage("Le Bon de Sortie et inexistant");
                    }
                    return LeBonSortie;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Insert(BonSortie bs)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(bs).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(bs.LeDepanneur).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Update(BonSortie bs)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(bs).State = EntityState.Modified;
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
