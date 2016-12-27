using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class DataSourceMap : EntityTypeConfiguration<DataSource>
    {
        public DataSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DataSrc_ID)
                .HasMaxLength(6);

            this.Property(t => t.Authors)
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .HasMaxLength(255);

            this.Property(t => t.Year)
                .HasMaxLength(4);

            this.Property(t => t.Journal)
                .HasMaxLength(135);

            this.Property(t => t.VolumeCity)
                .HasMaxLength(16);

            this.Property(t => t.IssueState)
                .HasMaxLength(5);

            this.Property(t => t.StartPage)
                .HasMaxLength(5);

            this.Property(t => t.EndPage)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("DataSource");
            this.Property(t => t.DataSrc_ID).HasColumnName("DataSrc_ID");
            this.Property(t => t.Authors).HasColumnName("Authors");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Journal).HasColumnName("Journal");
            this.Property(t => t.VolumeCity).HasColumnName("VolumeCity");
            this.Property(t => t.IssueState).HasColumnName("IssueState");
            this.Property(t => t.StartPage).HasColumnName("StartPage");
            this.Property(t => t.EndPage).HasColumnName("EndPage");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
