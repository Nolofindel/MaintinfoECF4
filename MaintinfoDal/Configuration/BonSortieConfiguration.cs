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
    class BonSortieConfiguration : EntityTypeConfiguration<BonSortie>
    {
        public BonSortieConfiguration():base()
        {
            HasKey(bs => bs.BonSortieID);
            Property(bs => bs.BonSortieID)
                .IsRequired();
            Property(bs => bs.Quantite)
                .IsRequired();

            Property(bs => bs.DateDemande)
                .IsRequired()
                .HasColumnType("date");

            //Association
            HasRequired(bs => bs.NomDepanneur)
                .WithMany()
                .HasForeignKey(bs => bs.DepanneurID);
            HasRequired(bs => bs.ArticleSortie)
                .WithMany()
                .HasForeignKey(bs => bs.ArticleID);

        }
    }
}
