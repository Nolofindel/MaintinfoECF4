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
    public class BonEntreeEntityDao : IRepository<BonEntree>
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

                    throw new DaoExceptionAfficheMessage("Impossible de supprimer le bon d'entrée! Erreur : " + Dex.Message);
                }
            }
        }

        public ICollection<BonEntree> GetAll()
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                //ICollection<BonEntree> LesBe = null;
                try
                {
                    var be = db.BonEntrees.Include(p => p.ArticleEntree).ToList();
                    return be;
                    //var AllBonEntrees = db.BonEntrees;
                    //foreach (BonEntree item in AllBonEntrees)
                    //{
                    //    LesBe.Add(item);
                    //}
                    //return LesBe;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Impossible de récupérer les bons d'entrée! Erreur : " + Dex.Message);
                }
            }
        }

        public BonEntree GetById(object id)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.BonEntrees.Include(p => p.ArticleEntree).ToList();
                    var LeBe = db.BonEntrees.Find(id);
                    
                    if (LeBe == null)
                    {
                        throw new DaoExceptionAfficheMessage("Bon d'entrée inexistant");
                    }
                    return LeBe;
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Impossible de récupérer le bon d'entrée! Erreur : " + Dex.Message);
                }
            }
        }

        public void Insert(BonEntree be)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(be).State = EntityState.Added;
                    // les produits connexes
                    db.Entry(be.ArticleEntree).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Impossible d'ajouter le bon d'entrée! Erreur : " + Dex.Message);
                }
            }
        }

        public void Update(BonEntree be)
        {
            using (MaintinfoContext db = new MaintinfoContext())
            {
                try
                {
                    db.Entry(be).State = EntityState.Modified;
                    int n = db.SaveChanges();
                }
                catch (DaoExceptionAfficheMessage Dex)
                {

                    throw new DaoExceptionAfficheMessage("Impossible de modifier le bon d'entrée! Erreur : " + Dex.Message);
                }
            }
        }
    }
}
