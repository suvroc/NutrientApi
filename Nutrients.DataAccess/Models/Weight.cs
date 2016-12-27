using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Weight
    {
        public Weight()
        {
            this.WeightTranslations = new List<WeightTranslation>();
        }

        public string NDBNo { get; set; }
        public string Sequence { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> GramWeight { get; set; }
        public Nullable<short> NumDataPoints { get; set; }
        public Nullable<double> StdDev { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public virtual ICollection<WeightTranslation> WeightTranslations { get; set; }
    }
}
