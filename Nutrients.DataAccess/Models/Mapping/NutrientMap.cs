using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class NutrientMap : EntityTypeConfiguration<Nutrient>
    {
        public NutrientMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NutrientNumber)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.Units)
                .HasMaxLength(7);

            this.Property(t => t.TagName)
                .HasMaxLength(20);

            this.Property(t => t.DecimalPlaces)
                .HasMaxLength(1);

            this.Property(t => t.SSMA_TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Nutrient");
            this.Property(t => t.NutrientNumber).HasColumnName("NutrientNumber");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.TagName).HasColumnName("TagName");
            this.Property(t => t.DecimalPlaces).HasColumnName("DecimalPlaces");
            this.Property(t => t.Ord).HasColumnName("Ord");
            this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
