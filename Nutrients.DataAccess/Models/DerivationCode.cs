using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class DerivationCode
    {
        public DerivationCode()
        {
            this.NutrientDatas = new List<NutrientData>();
        }

        public string DerivationCode1 { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public virtual ICollection<NutrientData> NutrientDatas { get; set; }
    }
}
