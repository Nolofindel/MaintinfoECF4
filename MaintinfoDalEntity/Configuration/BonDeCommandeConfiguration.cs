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
    class BonDeCommandeConfiguration: EntityTypeConfiguration<BonDeCommande>
    {
        public BonDeCommandeConfiguration():base()
        {
            HasKey(BdC => BdC.BonDeCommandeID);
            Property(BdC => BdC.BonDeCommandeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(BdC => BdC.DateCommande)
                .IsRequired();
            Property(BdC => BdC.QuantiteCommande)
                .IsRequired();
            Property(BdC => BdC.CommandeEffectue)
                .IsRequired();

            // Association  (pour ArticleSortie) 
            HasRequired(BdC => BdC.ArticleCommande)
                .WithMany()
                .HasForeignKey(BdC => BdC.ArticleID);
        }
    }
}
