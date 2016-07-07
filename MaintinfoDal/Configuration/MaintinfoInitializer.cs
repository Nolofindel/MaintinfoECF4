using System.Data.Entity;
using MaintinfoBo;

namespace MaintinfoDAL.Configuration
{
    public class MaintinfoInitializer : DropCreateDatabaseAlways<MaintinfoContext>
    {
        protected override void Seed(MaintinfoContext context)
        {

            Specialite spec1 = new Specialite("Physicien");
            Specialite spec2 = new Specialite("Necromancien");
            Specialite spec3 = new Specialite("Punkachien");

            context.Specialites.Add(spec1);
            context.Specialites.Add(spec2);
            context.Specialites.Add(spec3);

            Depanneur depa1 = new Depanneur()
            {
                NomDepanneur = "Erwin Schrodinger",
                SpecialiteDepanneur = spec1
            };
            context.Depanneurs.Add(depa1);

            Article art1 = new Article()
            {
                 NomArticle = "Accélérateur à particules",
                 QuantiteArticle = 10,
                 SeuilMinimal = 1
            };
            context.Articles.Add(art1);
        }
    }
}
