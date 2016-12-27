using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class LangualLinkMap : EntityTypeConfiguration<LangualLink>
    {
        public LangualLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDBNo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Factor)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("LangualLink");
            this.Property(t => t.NDBNo).HasColumnName("NDBNo");
            this.Property(t => t.Factor).HasColumnName("Factor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.LangualFactorId).HasColumnName("LangualFactorId");

            // Relationships
            this.HasOptional(t => t.Food)
                .WithMany(t => t.LangualLinks)
                .HasForeignKey(d => d.FoodId);
            this.HasOptional(t => t.LangualFactor)
                .WithMany(t => t.LangualLinks)
                .HasForeignKey(d => d.LangualFactorId);

        }
    }
}
