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
    class SecteurGeographiqueConfiguration:EntityTypeConfiguration<SecteurGeographique>
    {
        public SecteurGeographiqueConfiguration():base()
        {
            //TODO Rajouter la key dans la classe
            //HasKey(Sg => Sg.);
            //Property(Sg => Sg.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(Sg => Sg.NomSecteurGeographique)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
