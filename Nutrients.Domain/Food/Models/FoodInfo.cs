using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrients.Domain.Food.Models
{
    public class FoodInfo
    {
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string CommonName { get; set; }

        public IEnumerable<FoodNutrientData> Nutrients { get; set; } 
    }
}
