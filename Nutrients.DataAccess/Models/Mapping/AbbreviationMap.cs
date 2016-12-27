using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Nutrients.DataAccess.Models.Mapping
{
    public class AbbreviationMap : EntityTypeConfiguration<Abbreviation>
    {
        public AbbreviationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.NDB_No)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Shrt_Desc)
                .HasMaxLength(60);

            this.Property(t => t.GmWt_Desc1)
                .HasMaxLength(120);

            this.Property(t => t.GmWt_Desc2)
                .HasMaxLength(120);

            this.Property(t => t.SSMA_TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Abbreviation");
            this.Property(t => t.NDB_No).HasColumnName("NDB_No");
            this.Property(t => t.Shrt_Desc).HasColumnName("Shrt_Desc");
            this.Property(t => t.Water__g_).HasColumnName("Water_(g)");
            this.Property(t => t.Energ_Kcal).HasColumnName("Energ_Kcal");
            this.Property(t => t.Protein__g_).HasColumnName("Protein_(g)");
            this.Property(t => t.Lipid_Tot__g_).HasColumnName("Lipid_Tot_(g)");
            this.Property(t => t.Ash__g_).HasColumnName("Ash_(g)");
            this.Property(t => t.Carbohydrt__g_).HasColumnName("Carbohydrt_(g)");
            this.Property(t => t.Fiber_TD__g_).HasColumnName("Fiber_TD_(g)");
            this.Property(t => t.Sugar_Tot__g_).HasColumnName("Sugar_Tot_(g)");
            this.Property(t => t.Calcium__mg_).HasColumnName("Calcium_(mg)");
            this.Property(t => t.Iron__mg_).HasColumnName("Iron_(mg)");
            this.Property(t => t.Magnesium__mg_).HasColumnName("Magnesium_(mg)");
            this.Property(t => t.Phosphorus__mg_).HasColumnName("Phosphorus_(mg)");
            this.Property(t => t.Potassium__mg_).HasColumnName("Potassium_(mg)");
            this.Property(t => t.Sodium__mg_).HasColumnName("Sodium_(mg)");
            this.Property(t => t.Zinc__mg_).HasColumnName("Zinc_(mg)");
            this.Property(t => t.Copper_mg_).HasColumnName("Copper_mg)");
            this.Property(t => t.Manganese__mg_).HasColumnName("Manganese_(mg)");
            this.Property(t => t.Selenium__µg_).HasColumnName("Selenium_(µg)");
            this.Property(t => t.Vit_C__mg_).HasColumnName("Vit_C_(mg)");
            this.Property(t => t.Thiamin__mg_).HasColumnName("Thiamin_(mg)");
            this.Property(t => t.Riboflavin__mg_).HasColumnName("Riboflavin_(mg)");
            this.Property(t => t.Niacin__mg_).HasColumnName("Niacin_(mg)");
            this.Property(t => t.Panto_Acid_mg_).HasColumnName("Panto_Acid_mg)");
            this.Property(t => t.Vit_B6__mg_).HasColumnName("Vit_B6_(mg)");
            this.Property(t => t.Folate_Tot__µg_).HasColumnName("Folate_Tot_(µg)");
            this.Property(t => t.Folic_Acid__µg_).HasColumnName("Folic_Acid_(µg)");
            this.Property(t => t.Food_Folate__µg_).HasColumnName("Food_Folate_(µg)");
            this.Property(t => t.Folate_DFE__µg_).HasColumnName("Folate_DFE_(µg)");
            this.Property(t => t.Choline_Tot___mg_).HasColumnName("Choline_Tot_ (mg)");
            this.Property(t => t.Vit_B12__µg_).HasColumnName("Vit_B12_(µg)");
            this.Property(t => t.Vit_A_IU).HasColumnName("Vit_A_IU");
            this.Property(t => t.Vit_A_RAE).HasColumnName("Vit_A_RAE");
            this.Property(t => t.Retinol__µg_).HasColumnName("Retinol_(µg)");
            this.Property(t => t.Alpha_Carot__µg_).HasColumnName("Alpha_Carot_(µg)");
            this.Property(t => t.Beta_Carot__µg_).HasColumnName("Beta_Carot_(µg)");
            this.Property(t => t.Beta_Crypt__µg_).HasColumnName("Beta_Crypt_(µg)");
            this.Property(t => t.Lycopene__µg_).HasColumnName("Lycopene_(µg)");
            this.Property(t => t.Lut_Zea___µg_).HasColumnName("Lut+Zea_ (µg)");
            this.Property(t => t.Vit_E__mg_).HasColumnName("Vit_E_(mg)");
            this.Property(t => t.Vit_D_µg).HasColumnName("Vit_D_µg");
            this.Property(t => t.Vit_D_IU).HasColumnName("Vit_D_IU");
            this.Property(t => t.Vit_K__µg_).HasColumnName("Vit_K_(µg)");
            this.Property(t => t.FA_Sat__g_).HasColumnName("FA_Sat_(g)");
            this.Property(t => t.FA_Mono__g_).HasColumnName("FA_Mono_(g)");
            this.Property(t => t.FA_Poly__g_).HasColumnName("FA_Poly_(g)");
            this.Property(t => t.Cholestrl__mg_).HasColumnName("Cholestrl_(mg)");
            this.Property(t => t.GmWt_1).HasColumnName("GmWt_1");
            this.Property(t => t.GmWt_Desc1).HasColumnName("GmWt_Desc1");
            this.Property(t => t.GmWt_2).HasColumnName("GmWt_2");
            this.Property(t => t.GmWt_Desc2).HasColumnName("GmWt_Desc2");
            this.Property(t => t.Refuse_Pct).HasColumnName("Refuse_Pct");
            this.Property(t => t.SSMA_TimeStamp).HasColumnName("SSMA_TimeStamp");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FoodId).HasColumnName("FoodId");

            // Relationships
            this.HasOptional(t => t.Food)
                .WithMany(t => t.Abbreviations)
                .HasForeignKey(d => d.FoodId);

        }
    }
}
