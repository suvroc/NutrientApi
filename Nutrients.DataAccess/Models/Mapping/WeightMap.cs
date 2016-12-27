using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class WeightMap : EntityTypeConfiguration<Weight>
    {
        public WeightMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDBNo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Sequence)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.SSMA_TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Weight");
            this.Property(t => t.NDBNo).HasColumnName("NDBNo");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.GramWeight).HasColumnName("GramWeight");
            this.Property(t => t.NumDataPoints).HasColumnName("NumDataPoints");
            this.Property(t => t.StdDev).HasColumnName("StdDev");
            this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodId).HasColumnName("FoodId");
        }
    }
}
