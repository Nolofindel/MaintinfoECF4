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
            HasKey(Sp => Sp.SpecialiteID);
            Property(Sp => Sp.SpecialiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(Sp => Sp.NomSpecialite)
                .HasColumnName("Specialite")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
