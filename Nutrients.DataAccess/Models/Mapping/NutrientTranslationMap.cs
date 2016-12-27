using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class NutrientTranslationMap : EntityTypeConfiguration<NutrientTranslation>
    {
        public NutrientTranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("NutrientTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.NutrientId).HasColumnName("NutrientId");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.NutrientTranslations)
                .HasForeignKey(d => d.LanguageId);
            this.HasRequired(t => t.Nutrient)
                .WithMany(t => t.NutrientTranslations)
                .HasForeignKey(d => d.NutrientId);

        }
    }
}
