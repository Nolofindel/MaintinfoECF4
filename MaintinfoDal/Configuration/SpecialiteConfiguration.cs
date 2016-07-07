using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoBo;
using System.Data.Entity.ModelConfiguration;

namespace MaintinfoDAL.Configuration
{
    class SpecialiteConfiguration : EntityTypeConfiguration<Specialite>
    {
        public SpecialiteConfiguration() : base()
        {
            HasKey(spe => spe.SpecialiteID);
            Property(spe => spe.SpecialiteID)
                .IsRequired();

            Property(spe => spe.NomSpecialite)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(15);

        }
    }
}
