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
            //TODO Rajouter la key dans la classe
            //HasKey(Be => Be.);
            //Property(Be => Be.)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
            //    .IsRequired();
            Property(Be => Be.QuantiteEntree)
                .HasColumnName("")
                .HasColumnType("smallint")
                .IsRequired();
            Property(Be => Be.DateEntree)
                .HasColumnName("")
                .HasColumnType("date")
                .IsRequired();


        }
    }
}
