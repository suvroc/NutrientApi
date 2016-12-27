using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Nutrient
    {
        public Nutrient()
        {
            this.DataSourceLinks = new List<DataSourceLink>();
            this.NutrientDatas = new List<NutrientData>();
            this.NutrientTranslations = new List<NutrientTranslation>();
        }

        public string NutrientNumber { get; set; }
        public string Units { get; set; }
        public string TagName { get; set; }
        public string DecimalPlaces { get; set; }
        public Nullable<float> Ord { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public int Id { get; set; }
        public virtual ICollection<DataSourceLink> DataSourceLinks { get; set; }
        public virtual ICollection<NutrientData> NutrientDatas { get; set; }
        public virtual ICollection<NutrientTranslation> NutrientTranslations { get; set; }
    }
}
