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
            HasKey(art => art.DesignationArticle);
            Property(art => art.DesignationArticle)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();
            Property(art => art.NomArticle)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();
            Property(art => art.QuantiteArticle)
                .HasColumnName("")
                //.HasColumnType("")
                .IsRequired();
            Property(art => art.SeuilMinimal)
                .HasColumnName("")
                //.HasColumnType("")
                .IsRequired();

            Ignore(art => art.Self);
        }
    }
}
