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
            //TODO Rajouter la key dans la classe
            //HasKey(BdC => BdC.);
            //Property(BdC => BdC.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(BdC => BdC.DateCommande)
                .HasColumnName("")
                .HasColumnType("date")
                .IsRequired();
            Property(BdC => BdC.QuantiteCommande)
                .HasColumnName("")
                .HasColumnType("smallint")
                .IsRequired();
            Property(BdC => BdC.CommandeEffectue)
                .HasColumnName("")
                .HasColumnType("boolean")
                .IsRequired();
        }
    }
}
