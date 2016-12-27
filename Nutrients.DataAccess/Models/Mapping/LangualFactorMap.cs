using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class LangualFactorMap : EntityTypeConfiguration<LangualFactor>
    {
        public LangualFactorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Factor)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("LangualFactor");
            this.Property(t => t.Factor).HasColumnName("Factor");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
