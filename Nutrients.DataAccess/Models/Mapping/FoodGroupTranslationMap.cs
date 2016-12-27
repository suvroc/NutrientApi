using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class FoodGroupTranslationMap : EntityTypeConfiguration<FoodGroupTranslation>
    {
        public FoodGroupTranslationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.FoodGroupId, t.LanguageId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FoodGroupId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .HasMaxLength(120);

            this.Property(t => t.LanguageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FoodGroupTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodGroupId).HasColumnName("FoodGroupId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");

            // Relationships
            this.HasRequired(t => t.FoodGroup)
                .WithMany(t => t.FoodGroupTranslations)
                .HasForeignKey(d => d.FoodGroupId);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.FoodGroupTranslations)
                .HasForeignKey(d => d.LanguageId);

        }
    }
}
