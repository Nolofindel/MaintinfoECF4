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
    public class DepanneurEntityDao : IRepository<Depanneur>
    {
        public void Delete(Depanneur dep)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Depanneurs.Attach(dep);
                    db.Depanneurs.Remove(dep);
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Erreur : " + Dex.Message);
                }
            }
        }

        public ICollection<Depanneur> GetAll()
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                ICollection<Depanneur> LesDep = null;
                try
                {
                    var AllDepanneurs = db.Depanneurs;
                    foreach (Depanneur item in AllDepanneurs)
                    {
                        LesDep.Add(item);
                    }
                    return LesDep;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public Depanneur GetById(object id)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    var LeDepanneur = db.Depanneurs.Find(id);
                    if (LeDepanneur == null)
                    {
                        throw new DaoExceptionAfficheMessage("Le Depanneur et inexistant");
                    }
                    return LeDepanneur;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Insert(Depanneur dep)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(dep).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(dep.SpecialiteDepanneur).State = EntityState.Unchanged;
                    db.Entry(dep.SecteurGeographiqueDepanneur).State = EntityState.Unchanged;
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("" + Dex.Message);
                }
            }
        }

        public void Update(Depanneur dep)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(dep).State = EntityState.Modified;
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
