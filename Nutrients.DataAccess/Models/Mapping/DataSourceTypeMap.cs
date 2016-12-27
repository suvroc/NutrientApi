using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class DataSourceTypeMap : EntityTypeConfiguration<DataSourceType>
    {
        public DataSourceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.Description)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("DataSourceType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
