using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutrients.DataAccess;
using Nutrients.Domain.Food.Models;

namespace Nutrients.Domain.Food
{
    public class FoodService : IFoodService
    {
        private readonly NutrientDbContext _dbContext;

        public FoodService(NutrientDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FoodInfo> FindFoodInfo(string name)
        {
            return _dbContext.Foods
                .Select(x => new FoodInfo()
                {
                    ShortDescription = x.ShortDescription,
                    LongDescription = x.LongDescription
                }).ToList();
        }
    }
}
