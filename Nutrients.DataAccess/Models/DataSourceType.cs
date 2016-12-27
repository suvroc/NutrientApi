using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class DataSourceType
    {
        public DataSourceType()
        {
            this.NutrientDatas = new List<NutrientData>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public virtual ICollection<NutrientData> NutrientDatas { get; set; }
    }
}
