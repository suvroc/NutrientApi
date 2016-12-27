using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutrients.Domain.Food.Models;

namespace Nutrients.Domain.Food
{
    public class FoodService : IFoodService
    {
        public FoodInfo FindFoodInfo(string name)
        {
            return new FoodInfo();
        }
    }
}
