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
    class DepanneurConfiguration:EntityTypeConfiguration<Depanneur>
    {
        public DepanneurConfiguration():base()
        {
            //TODO Rajouter la key dans la classe
            //HasKey(Dep => Dep.);
            //Property(Dep => Dep.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(Dep => Dep.NomDepanneur)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

        }
    }
}
