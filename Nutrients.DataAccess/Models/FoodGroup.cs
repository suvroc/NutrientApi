using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class FoodGroup
    {
        public FoodGroup()
        {
            this.Foods = new List<Food>();
            this.FoodGroupTranslations = new List<FoodGroupTranslation>();
        }

        public string Code { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<FoodGroupTranslation> FoodGroupTranslations { get; set; }
    }
}
