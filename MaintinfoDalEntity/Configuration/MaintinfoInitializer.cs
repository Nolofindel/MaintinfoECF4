using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MaintinfoBo;

namespace MaintinfoDalEntity.Configuration
{
    public class MaintinfoInitializer:DropCreateDatabaseAlways<MaintinfoContext>
    {
        protected override void Seed(MaintinfoContext db)
        {

            //Les Secteurs Geographique
            SecteurGeographique SectGeo1 = new SecteurGeographique("Bouche du rhône");
            SecteurGeographique SectGeo2 = new SecteurGeographique("Lorainne");
            SecteurGeographique SectGeo3 = new SecteurGeographique("Marseille");
            SecteurGeographique SectGeo4 = new SecteurGeographique("Ile de france");
            SecteurGeographique SectGeo5 = new SecteurGeographique("Bretagne");
            SecteurGeographique SectGeo6 = new SecteurGeographique("Tchernobyl");
            //Ajout des Secteurs Geographique
            db.SecteurGeographiques.Add(SectGeo1);
            db.SecteurGeographiques.Add(SectGeo2);
            db.SecteurGeographiques.Add(SectGeo3);
            db.SecteurGeographiques.Add(SectGeo4);
            db.SecteurGeographiques.Add(SectGeo5);
            db.SecteurGeographiques.Add(SectGeo6);

            //Les depanneurs
            Specialite Spec1 = new Specialite("Windows");
            Specialite Spec2 = new Specialite("Apple");
            Specialite Spec3 = new Specialite("Materiel informatique");
            Specialite Spec4 = new Specialite("Serveur");
            Specialite Spec5 = new Specialite("Téléphone");
            Specialite Spec6 = new Specialite("Nucleair");
            //Ajout des depanneurs
            db.Specialites.Add(Spec1);
            db.Specialites.Add(Spec2);
            db.Specialites.Add(Spec3);
            db.Specialites.Add(Spec4);
            db.Specialites.Add(Spec5);
            db.Specialites.Add(Spec6);

            //les Articles
            Article Art1 = new Article { DesignationArticle = "A125", NomArticle = "MacBook Pro", QuantiteArticle = 800, SeuilMinimal = 400 };
            Article Art2 = new Article { DesignationArticle = "A132", NomArticle = "Dell F500", QuantiteArticle = 150, SeuilMinimal = 20 };
            Article Art3 = new Article { DesignationArticle = "Z125", NomArticle = "Pile Rad 800", QuantiteArticle = 12, SeuilMinimal = 3 };
            Article Art4 = new Article { DesignationArticle = "P125", NomArticle = "Phone mf 12", QuantiteArticle = 210, SeuilMinimal = 40 };
            Article Art5 = new Article { DesignationArticle = "I125", NomArticle = "Nas syno rb85d", QuantiteArticle = 85, SeuilMinimal = 80 };
            Article Art6 = new Article { DesignationArticle = "R125", NomArticle = "Chichi", QuantiteArticle = 400, SeuilMinimal = 300 };
            //Ajout des articles
            db.Articles.Add(Art1);
            db.Articles.Add(Art2);
            db.Articles.Add(Art3);
            db.Articles.Add(Art4);
            db.Articles.Add(Art5);
            db.Articles.Add(Art6);

            //Les depanneurs
            Depanneur Dep1 = new Depanneur { NomDepanneur = "BOUSOULOUF", PrenomDepanneur = "Radouane", SpecialiteDepanneur = Spec6, SecteurGeographiqueDepanneur = SectGeo1 };
            Depanneur Dep2 = new Depanneur { NomDepanneur = "GOAT", PrenomDepanneur = "Lucas", SpecialiteDepanneur = Spec2, SecteurGeographiqueDepanneur = SectGeo2 };
            Depanneur Dep3 = new Depanneur { NomDepanneur = "FIG", PrenomDepanneur = "Benjamin", SpecialiteDepanneur = Spec3, SecteurGeographiqueDepanneur = SectGeo3 };
            Depanneur Dep4 = new Depanneur { NomDepanneur = "BUS", PrenomDepanneur = "Mourad", SpecialiteDepanneur = Spec4, SecteurGeographiqueDepanneur = SectGeo4 };
            Depanneur Dep5 = new Depanneur { NomDepanneur = "POMME", PrenomDepanneur = "Laurent", SpecialiteDepanneur = Spec5, SecteurGeographiqueDepanneur = SectGeo5 };
            Depanneur Dep6 = new Depanneur { NomDepanneur = "KASSOS", PrenomDepanneur = "Mohamed", SpecialiteDepanneur = Spec1, SecteurGeographiqueDepanneur = SectGeo6 };
            //Ajout des depanneurs
            db.Depanneurs.Add(Dep1);
            db.Depanneurs.Add(Dep2);
            db.Depanneurs.Add(Dep3);
            db.Depanneurs.Add(Dep4);
            db.Depanneurs.Add(Dep5);
            db.Depanneurs.Add(Dep6);

            //Les Bon de sortie
            BonSortie Bs1 = new BonSortie { LeDepanneur = Dep1, ArticleSortie = Art1, Quantite = 2, DateDemande = DateTime.Today };
            BonSortie Bs2 = new BonSortie { LeDepanneur = Dep2, ArticleSortie = Art2, Quantite = 2, DateDemande = DateTime.Today };
            BonSortie Bs3 = new BonSortie { LeDepanneur = Dep3, ArticleSortie = Art3, Quantite = 2, DateDemande = DateTime.Today };

            //Ajout des Bon d'entrée
            db.BonSorties.Add(Bs1);
            db.BonSorties.Add(Bs2);
            db.BonSorties.Add(Bs3);

            //Les Bon d'entrée
            BonEntree Be1 = new BonEntree { ArticleEntree=Art1,QuantiteEntree=12,DateEntree = DateTime.Today };

            //Ajout des Bon de commande
            db.BonEntrees.Add(Be1);

            //Les Bon de commande
            BonDeCommande BdC1 = new BonDeCommande {ArticleCommande = Art2,QuantiteCommande=111,DateCommande = DateTime.Today, CommandeEffectue=true };

            //Ajout des Bon de sortie
            db.BonDeCommandes.Add(BdC1);

        }
    }
}
