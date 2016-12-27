using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class DerivationCodeMap : EntityTypeConfiguration<DerivationCode>
    {
        public DerivationCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DerivationCode1)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Description)
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("DerivationCode");
            this.Property(t => t.DerivationCode1).HasColumnName("DerivationCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
