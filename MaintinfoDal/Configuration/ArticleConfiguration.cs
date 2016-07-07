using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaintinfoDAL.Configuration
{
    class ArticleConfiguration : EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration():base()
        {
            HasKey(art => art.ArticleID);
            Property(art => art.ArticleID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(art => art.NomArticle)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("varchar");
            Property(art => art.QuantiteArticle)
                .IsRequired();
        }
    }
}
