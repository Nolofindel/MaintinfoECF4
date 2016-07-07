using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using MaintinfoBo;

namespace MaintinfoDalEntity.Configuration
{
    class ArticleConfiguration:EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration():base()
        {
            HasKey(art =>new { art.ArticleID, art.DesignationArticle });
            Property(art => art.ArticleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(art => art.DesignationArticle)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();
            Property(art => art.NomArticle)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();
            Property(art => art.QuantiteArticle)
                .IsRequired();
            Property(art => art.SeuilMinimal)
                .IsRequired();

            Ignore(art => art.Self);
            Ignore(art => art.SousEnsemble);

            //HasMany(art => art.SousEnsemble)
            //    .WithOptional();
        }
    }
}
