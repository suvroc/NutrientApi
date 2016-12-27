using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class LangualFactor
    {
        public LangualFactor()
        {
            this.LangualLinks = new List<LangualLink>();
        }

        public string Factor { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public virtual ICollection<LangualLink> LangualLinks { get; set; }
    }
}
