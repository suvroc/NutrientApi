using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class FoodGroupMap : EntityTypeConfiguration<FoodGroup>
    {
        public FoodGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("FoodGroup");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
