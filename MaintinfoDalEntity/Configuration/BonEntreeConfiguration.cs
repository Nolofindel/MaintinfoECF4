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
    class BonEntreeConfiguration: EntityTypeConfiguration<BonEntree>
    {
        public BonEntreeConfiguration():base()
        {
            HasKey(Be => Be.BonEntreeID);
            Property(Be => Be.BonEntreeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(Be => Be.QuantiteEntree)
                .IsRequired();
            Property(Be => Be.DateEntree)
                .IsRequired();

            // Association  (pour ArticleSortie) 
            HasRequired(Be => Be.ArticleEntree)
                .WithMany()
                .HasForeignKey(Be => Be.ArticleID);


        }
    }
}
