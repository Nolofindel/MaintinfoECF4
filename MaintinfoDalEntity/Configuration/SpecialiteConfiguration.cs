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
    class SpecialiteConfiguration:EntityTypeConfiguration<Specialite>
    {
        public SpecialiteConfiguration():base()
        {
            //TODO Rajouter la key dans la classe
            //HasKey(Sp => Sp.);
            //Property(Sp => Sp.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(Sp => Sp.NomSpecialite)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
