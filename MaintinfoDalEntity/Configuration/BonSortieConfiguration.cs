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
    class BonSortieConfiguration: EntityTypeConfiguration<BonSortie>
    {
        public BonSortieConfiguration():base()
        {
            HasKey(Bs => Bs.BonSortieID);
            Property(Bs => Bs.BonSortieID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(Bs => Bs.Quantite)
                .HasColumnName("")
                .HasColumnType("smallint")
                .IsRequired();
            Property(Bs => Bs.DateDemande)
                .HasColumnName("")
                .HasColumnType("date")
                .IsRequired();

            // Association  (pour LeDepanneur) 
            HasRequired(Bs => Bs.LeDepanneur)
                .WithMany()
                .HasForeignKey(Bs => Bs.DepanneurID);

            // Association  (pour ArticleSortie) 
            HasRequired(Bs => Bs.ArticleSortie)
                .WithMany()
                .HasForeignKey(Bs => Bs.ArticleID);

        }
    }
}
