using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class FootnoteMap : EntityTypeConfiguration<Footnote>
    {
        public FootnoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDBNo)
                .HasMaxLength(5);

            this.Property(t => t.Footnt_No)
                .HasMaxLength(4);

            this.Property(t => t.Footnot_Typ)
                .HasMaxLength(1);

            this.Property(t => t.Nutr_No)
                .HasMaxLength(3);

            this.Property(t => t.Footnot_Txt)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Footnote");
            this.Property(t => t.NDBNo).HasColumnName("NDBNo");
            this.Property(t => t.Footnt_No).HasColumnName("Footnt_No");
            this.Property(t => t.Footnot_Typ).HasColumnName("Footnot_Typ");
            this.Property(t => t.Nutr_No).HasColumnName("Nutr_No");
            this.Property(t => t.Footnot_Txt).HasColumnName("Footnot_Txt");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodId).HasColumnName("FoodId");

            // Relationships
            this.HasOptional(t => t.Food)
                .WithMany(t => t.Footnotes)
                .HasForeignKey(d => d.FoodId);

        }
    }
}
