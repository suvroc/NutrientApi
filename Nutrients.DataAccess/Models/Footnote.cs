using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class Footnote
    {
        public string NDBNo { get; set; }
        public string Footnt_No { get; set; }
        public string Footnot_Typ { get; set; }
        public string Nutr_No { get; set; }
        public string Footnot_Txt { get; set; }
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public virtual Food Food { get; set; }
    }
}
