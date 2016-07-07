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
    class DepanneurConfiguration : EntityTypeConfiguration<Depanneur>
    {
        public DepanneurConfiguration():base()
        {
            HasKey(depa => depa.DepanneurID);
            Property(depa => depa.DepanneurID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(depa => depa.NomDepanneur)
                .IsRequired()
                .HasMaxLength(10)
                // Equivalent à .HasColumnType("varchar");
                .IsUnicode(false);
                

            // Association  (pour LaSpécialité)
            HasRequired(p => p.SpecialiteDepanneur)
                .WithMany()
                .HasForeignKey(p => p.SpecialiteID);
        }
    }
}
