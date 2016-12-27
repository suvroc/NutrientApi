using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class FoodMap : EntityTypeConfiguration<Food>
    {
        public FoodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDBNo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.LongDescription)
                .HasMaxLength(200);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(60);

            this.Property(t => t.CommonName)
                .HasMaxLength(100);

            this.Property(t => t.ManufacureName)
                .HasMaxLength(65);

            this.Property(t => t.Survey)
                .HasMaxLength(1);

            this.Property(t => t.RefuseDescription)
                .HasMaxLength(135);

            this.Property(t => t.ScientificName)
                .HasMaxLength(65);

            this.Property(t => t.SSMA_TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Food");
            this.Property(t => t.NDBNo).HasColumnName("NDBNo");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.CommonName).HasColumnName("CommonName");
            this.Property(t => t.ManufacureName).HasColumnName("ManufacureName");
            this.Property(t => t.Survey).HasColumnName("Survey");
            this.Property(t => t.RefuseDescription).HasColumnName("RefuseDescription");
            this.Property(t => t.RefusePercent).HasColumnName("RefusePercent");
            this.Property(t => t.ScientificName).HasColumnName("ScientificName");
            this.Property(t => t.NitrogenFactor).HasColumnName("NitrogenFactor");
            this.Property(t => t.ProteinFactor).HasColumnName("ProteinFactor");
            this.Property(t => t.FatFactor).HasColumnName("FatFactor");
            this.Property(t => t.ChoFactor).HasColumnName("ChoFactor");
            this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
            this.Property(t => t.FoodGroupId).HasColumnName("FoodGroupId");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasOptional(t => t.FoodGroup)
                .WithMany(t => t.Foods)
                .HasForeignKey(d => d.FoodGroupId);

        }
    }
}
