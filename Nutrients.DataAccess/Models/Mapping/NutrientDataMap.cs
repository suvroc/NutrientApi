using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class NutrientDataMap : EntityTypeConfiguration<NutrientData>
    {
        public NutrientDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDBNo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.RefNDBNo)
                .HasMaxLength(5);

            this.Property(t => t.AddedNutrient)
                .HasMaxLength(1);

            this.Property(t => t.StatComment)
                .HasMaxLength(10);

            this.Property(t => t.ModDate)
                .HasMaxLength(10);

            this.Property(t => t.SSMA_TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("NutrientData");
            this.Property(t => t.NDBNo).HasColumnName("NDBNo");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.DataPoints).HasColumnName("DataPoints");
            this.Property(t => t.StdError).HasColumnName("StdError");
            this.Property(t => t.RefNDBNo).HasColumnName("RefNDBNo");
            this.Property(t => t.AddedNutrient).HasColumnName("AddedNutrient");
            this.Property(t => t.NumStudies).HasColumnName("NumStudies");
            this.Property(t => t.Min).HasColumnName("Min");
            this.Property(t => t.Max).HasColumnName("Max");
            this.Property(t => t.FreedomDegree).HasColumnName("FreedomDegree");
            this.Property(t => t.LowErrorBound).HasColumnName("LowErrorBound");
            this.Property(t => t.UpErrorBound).HasColumnName("UpErrorBound");
            this.Property(t => t.StatComment).HasColumnName("StatComment");
            this.Property(t => t.ModDate).HasColumnName("ModDate");
            this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DataSourceTypeId).HasColumnName("DataSourceTypeId");
            this.Property(t => t.DerivationCodeId).HasColumnName("DerivationCodeId");
            this.Property(t => t.NutrientId).HasColumnName("NutrientId");
            this.Property(t => t.FoodId).HasColumnName("FoodId");

            // Relationships
            this.HasOptional(t => t.DataSourceType)
                .WithMany(t => t.NutrientDatas)
                .HasForeignKey(d => d.DataSourceTypeId);
            this.HasOptional(t => t.DerivationCode)
                .WithMany(t => t.NutrientDatas)
                .HasForeignKey(d => d.DerivationCodeId);
            this.HasOptional(t => t.Food)
                .WithMany(t => t.NutrientDatas)
                .HasForeignKey(d => d.FoodId);
            this.HasOptional(t => t.Nutrient)
                .WithMany(t => t.NutrientDatas)
                .HasForeignKey(d => d.NutrientId);

        }
    }
}
