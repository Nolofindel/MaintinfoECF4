namespace MaintinfoDalEntity.Configuration
{
    using MaintinfoBo;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MaintinfoContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « MaintinfoContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « MaintinfoDalEntity.Configuration.MaintinfoContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « MaintinfoContext » dans le fichier de configuration de l'application.
        public MaintinfoContext(): base("name=MaintinfoContext"){}

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<BonDeCommande> BonDeCommandes { get; set; }
        public DbSet<BonEntree> BonEntrees { get; set; }
        public DbSet<BonSortie> BonSorties { get; set; }
        public DbSet<Catalogue> Catalogue { get; set; }
        public DbSet<Depanneur> Depanneurs { get; set; }
        public DbSet<SecteurGeographique> SecteurGeographiques { get; set; }
        public DbSet<Specialite> Specialites { get; set; }

        //Configuration du model via API Fluent Code First
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ArticleConfiguration());
            modelBuilder.Configurations.Add(new BonDeCommandeConfiguration());
            modelBuilder.Configurations.Add(new BonEntreeConfiguration());
            modelBuilder.Configurations.Add(new BonSortieConfiguration());
            modelBuilder.Configurations.Add(new DepanneurConfiguration());
            modelBuilder.Configurations.Add(new SecteurGeographiqueConfiguration());
            modelBuilder.Configurations.Add(new SpecialiteConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}