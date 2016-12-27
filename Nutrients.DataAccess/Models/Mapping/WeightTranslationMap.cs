using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class WeightTranslationMap : EntityTypeConfiguration<WeightTranslation>
    {
        public WeightTranslationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.LanguageId, t.WeightId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.LanguageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeightId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MeasureDescription)
                .HasMaxLength(84);

            // Table & Column Mappings
            this.ToTable("WeightTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.WeightId).HasColumnName("WeightId");
            this.Property(t => t.MeasureDescription).HasColumnName("MeasureDescription");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.WeightTranslations)
                .HasForeignKey(d => d.LanguageId);
            this.HasRequired(t => t.Weight)
                .WithMany(t => t.WeightTranslations)
                .HasForeignKey(d => d.WeightId);

        }
    }
}
