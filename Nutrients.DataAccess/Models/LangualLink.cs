using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class LangualLink
    {
        public string NDBNo { get; set; }
        public string Factor { get; set; }
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public Nullable<int> LangualFactorId { get; set; }
        public virtual Food Food { get; set; }
        public virtual LangualFactor LangualFactor { get; set; }
    }
}
