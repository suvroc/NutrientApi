using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class DataSourceLink
    {
        public string NDB_No { get; set; }
        public string Nutr_No { get; set; }
        public string DataSrc_ID { get; set; }
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public Nullable<int> NutrientId { get; set; }
        public Nullable<int> DataSourceId { get; set; }
        public virtual DataSource DataSource { get; set; }
        public virtual Food Food { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
