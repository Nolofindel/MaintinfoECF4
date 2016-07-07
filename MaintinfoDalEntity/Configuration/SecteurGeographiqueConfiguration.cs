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
            HasKey(Sg => Sg.SecteurGeographiqueID);
            Property(Sg => Sg.SecteurGeographiqueID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(Sg => Sg.NomSecteurGeographique)
                .HasColumnName("SecteurGeographique")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
