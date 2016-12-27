using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class WeightTranslation
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int WeightId { get; set; }
        public string MeasureDescription { get; set; }
        public virtual Language Language { get; set; }
        public virtual Weight Weight { get; set; }
    }
}
