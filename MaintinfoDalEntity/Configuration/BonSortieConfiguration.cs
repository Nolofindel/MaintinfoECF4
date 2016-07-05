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
            //TODO Rajouter la key dans la classe
            //HasKey(Bs => Bs.);
            //Property(Bs => Bs.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(Bs => Bs.NomDepanneur)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            Property(Bs => Bs.Quantite)
                .HasColumnName("")
                .HasColumnType("smallint")
                .IsRequired();
            Property(Bs => Bs.DateDemande)
                .HasColumnName("")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
