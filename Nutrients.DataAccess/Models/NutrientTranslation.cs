using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class NutrientTranslation
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int NutrientId { get; set; }
        public string Description { get; set; }
        public virtual Language Language { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
