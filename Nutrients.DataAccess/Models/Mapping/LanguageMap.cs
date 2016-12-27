using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class LanguageMap : EntityTypeConfiguration<Language>
    {
        public LanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LanguageName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Language");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LanguageName).HasColumnName("LanguageName");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
        }
    }
}
