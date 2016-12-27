using System.Data.Entity;
using Nutrients.DataAccess.Models;
using Nutrients.DataAccess.Models.Mapping;

namespace Nutrients.DataAccess
{
    public partial class NutrientDbContext : DbContext
    {
        static NutrientDbContext()
        {
            Database.SetInitializer<NutrientDbContext>(null);
        }

        public NutrientDbContext()
            : base("Name=NutrientDbContext")
        {
        }

        public DbSet<Abbreviation> Abbreviations { get; set; }
        public DbSet<DataSource> DataSources { get; set; }
        public DbSet<DataSourceLink> DataSourceLinks { get; set; }
        public DbSet<DataSourceType> DataSourceTypes { get; set; }
        public DbSet<DerivationCode> DerivationCodes { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodGroup> FoodGroups { get; set; }
        public DbSet<FoodGroupTranslation> FoodGroupTranslations { get; set; }
        public DbSet<FoodTranslation> FoodTranslations { get; set; }
        public DbSet<Footnote> Footnotes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LangualFactor> LangualFactors { get; set; }
        public DbSet<LangualLink> LangualLinks { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientData> NutrientDatas { get; set; }
        public DbSet<NutrientTranslation> NutrientTranslations { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<WeightTranslation> WeightTranslations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbbreviationMap());
            modelBuilder.Configurations.Add(new DataSourceMap());
            modelBuilder.Configurations.Add(new DataSourceLinkMap());
            modelBuilder.Configurations.Add(new DataSourceTypeMap());
            modelBuilder.Configurations.Add(new DerivationCodeMap());
            modelBuilder.Configurations.Add(new FoodMap());
            modelBuilder.Configurations.Add(new FoodGroupMap());
            modelBuilder.Configurations.Add(new FoodGroupTranslationMap());
            modelBuilder.Configurations.Add(new FoodTranslationMap());
            modelBuilder.Configurations.Add(new FootnoteMap());
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new LangualFactorMap());
            modelBuilder.Configurations.Add(new LangualLinkMap());
            modelBuilder.Configurations.Add(new NutrientMap());
            modelBuilder.Configurations.Add(new NutrientDataMap());
            modelBuilder.Configurations.Add(new NutrientTranslationMap());
            modelBuilder.Configurations.Add(new WeightMap());
            modelBuilder.Configurations.Add(new WeightTranslationMap());
        }
    }
}
