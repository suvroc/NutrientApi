using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Language
    {
        public Language()
        {
            this.FoodGroupTranslations = new List<FoodGroupTranslation>();
            this.FoodTranslations = new List<FoodTranslation>();
            this.NutrientTranslations = new List<NutrientTranslation>();
            this.WeightTranslations = new List<WeightTranslation>();
        }

        public int Id { get; set; }
        public string LanguageName { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<FoodGroupTranslation> FoodGroupTranslations { get; set; }
        public virtual ICollection<FoodTranslation> FoodTranslations { get; set; }
        public virtual ICollection<NutrientTranslation> NutrientTranslations { get; set; }
        public virtual ICollection<WeightTranslation> WeightTranslations { get; set; }
    }
}
