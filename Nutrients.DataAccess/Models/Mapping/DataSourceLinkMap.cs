using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class DataSourceLinkMap : EntityTypeConfiguration<DataSourceLink>
    {
        public DataSourceLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDB_No)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Nutr_No)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.DataSrc_ID)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("DataSourceLink");
            this.Property(t => t.NDB_No).HasColumnName("NDB_No");
            this.Property(t => t.Nutr_No).HasColumnName("Nutr_No");
            this.Property(t => t.DataSrc_ID).HasColumnName("DataSrc_ID");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
            this.Property(t => t.NutrientId).HasColumnName("NutrientId");
            this.Property(t => t.DataSourceId).HasColumnName("DataSourceId");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.DataSourceLinks)
                .HasForeignKey(d => d.DataSourceId);
            this.HasOptional(t => t.Food)
                .WithMany(t => t.DataSourceLinks)
                .HasForeignKey(d => d.FoodId);
            this.HasOptional(t => t.Nutrient)
                .WithMany(t => t.DataSourceLinks)
                .HasForeignKey(d => d.NutrientId);

        }
    }
}
