using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class FoodGroupTranslation
    {
        public int Id { get; set; }
        public int FoodGroupId { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public virtual FoodGroup FoodGroup { get; set; }
        public virtual Language Language { get; set; }
    }
}
