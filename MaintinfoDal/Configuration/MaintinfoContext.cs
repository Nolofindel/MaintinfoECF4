using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using System.Data.Entity;


namespace MaintinfoDAL.Configuration
{
    public class MaintinfoContext : DbContext
    {
        public MaintinfoContext() : base("name = MaintinfoConnexion")
        { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<BonDeCommande> BonDeCommandes { get; set; }
        //public DbSet<BonEntree> BonEntrees { get; set; }
        public DbSet<BonSortie> BonSorties { get; set; }
        public DbSet<Depanneur> Depanneurs { get; set; }
        public DbSet<Specialite> Specialites{ get; set; }
    }
}
