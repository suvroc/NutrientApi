using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutrients.Domain.Food.Models;

namespace Nutrients.Domain.Food
{
    public interface IFoodService
    {
        List<FoodInfo> FindFoodInfo(string name);
    }
}
