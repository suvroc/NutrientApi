using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class FoodTranslation
    {
        public int Id { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> FoodId { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string CommonName { get; set; }
        public virtual Food Food { get; set; }
        public virtual Language Language { get; set; }
    }
}
