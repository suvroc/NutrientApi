using System.Collections.Generic;
using Nutrients.Domain.Food.Models;

namespace Nutrients.Domain.Food
{
    public interface IFoodService
    {
        List<Models.Food> FindFood(string searchText);
        List<FoodInfo> FindFoodInfo(string name);
        FoodInfo FindFoodInfo(int id);
    }
}
