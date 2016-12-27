using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Food
    {
        public Food()
        {
            this.Abbreviations = new List<Abbreviation>();
            this.DataSourceLinks = new List<DataSourceLink>();
            this.FoodTranslations = new List<FoodTranslation>();
            this.Footnotes = new List<Footnote>();
            this.LangualLinks = new List<LangualLink>();
            this.NutrientDatas = new List<NutrientData>();
        }

        public string NDBNo { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string CommonName { get; set; }
        public string ManufacureName { get; set; }
        public string Survey { get; set; }
        public string RefuseDescription { get; set; }
        public Nullable<short> RefusePercent { get; set; }
        public string ScientificName { get; set; }
        public Nullable<float> NitrogenFactor { get; set; }
        public Nullable<float> ProteinFactor { get; set; }
        public Nullable<float> FatFactor { get; set; }
        public Nullable<float> ChoFactor { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public Nullable<int> FoodGroupId { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Abbreviation> Abbreviations { get; set; }
        public virtual ICollection<DataSourceLink> DataSourceLinks { get; set; }
        public virtual FoodGroup FoodGroup { get; set; }
        public virtual ICollection<FoodTranslation> FoodTranslations { get; set; }
        public virtual ICollection<Footnote> Footnotes { get; set; }
        public virtual ICollection<LangualLink> LangualLinks { get; set; }
        public virtual ICollection<NutrientData> NutrientDatas { get; set; }
    }
}
