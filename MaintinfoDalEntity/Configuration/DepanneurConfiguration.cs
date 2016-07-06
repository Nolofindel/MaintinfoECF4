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
            HasKey(Dep => Dep.DepanneurID);
            Property(Dep => Dep.DepanneurID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(Dep => Dep.NomDepanneur)
                .HasColumnName("")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

            // Association  (pour la Specialite)
            HasRequired(Dep => Dep.SpecialiteDepanneur)
                .WithMany()
                .HasForeignKey(Dep => Dep.SpecialiteID);

            // Association  (pour la Secteur Geographique)
            HasRequired(Dep => Dep.SecteurGeographiqueDepanneur)
                .WithMany()
                .HasForeignKey(Dep => Dep.SecteurGeographiqueID);

        }
    }
}
