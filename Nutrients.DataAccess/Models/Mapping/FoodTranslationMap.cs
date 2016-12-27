using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class FoodTranslationMap : EntityTypeConfiguration<FoodTranslation>
    {
        public FoodTranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LongDescription)
                .HasMaxLength(400);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(120);

            this.Property(t => t.CommonName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FoodTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.CommonName).HasColumnName("CommonName");

            // Relationships
            this.HasOptional(t => t.Food)
                .WithMany(t => t.FoodTranslations)
                .HasForeignKey(d => d.FoodId);
            this.HasOptional(t => t.Language)
                .WithMany(t => t.FoodTranslations)
                .HasForeignKey(d => d.LanguageId);

        }
    }
}
