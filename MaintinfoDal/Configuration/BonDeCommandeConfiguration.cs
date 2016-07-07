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
    class BonDeCommandeConfiguration : EntityTypeConfiguration<BonDeCommande>
    {
        public BonDeCommandeConfiguration() : base()
        {

            HasKey(bdc => bdc.BonDeCommandeID);
            Property(bdc => bdc.BonDeCommandeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(bdc => bdc.DateCommande)
                .IsRequired()
                .HasColumnType("date");

            Property(bdc => bdc.QuantiteCommande)
                .IsRequired();

            Property(bdc => bdc.CommandeEffectue);
                //.HasColumnType("byte");

            //Association
            HasRequired(bdc => bdc.ArticleCommande)
                .WithMany()
                .HasForeignKey(bdc => bdc.ArticleID);
        }
    }
}
