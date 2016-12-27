using System.Collections.Generic;
using System.Linq;
using Nutrients.DataAccess;
using Nutrients.Domain.Food.Models;

namespace Nutrients.Domain.Food
{
    public class FoodService : IFoodService
    {
        private readonly NutrientDbContext _dbContext;

        private readonly string LanguageName = "English";
        private readonly string CountryName = "UK";

        public FoodService(NutrientDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public List<Models.Food> FindFood(string searchText)
        {
            var foods = _dbContext.FoodTranslations
                .Where(x => x.LongDescription.Contains(searchText))
                .Select(x => new Models.Food()
                {
                    Id = x.FoodId.Value,
                    Name = x.LongDescription
                }).ToList();

            return foods;
        }

        public List<FoodInfo> FindFoodInfo(string searchText)
        {
            var nutrientTranslations = _dbContext.NutrientTranslations
                .Where(x => x.Language.LanguageName == LanguageName && x.Language.CountryName == CountryName);

            var foodTranslations = _dbContext.FoodTranslations
                .Where(x => x.Language.LanguageName == LanguageName && x.Language.CountryName == CountryName
                    && x.LongDescription.Contains(searchText)).Select(x => x.FoodId);

            var foods = _dbContext.Foods
                .Where(x => foodTranslations.Contains(x.Id))
                .Select(x => new FoodInfo()
                {
                    ShortDescription = x.ShortDescription,
                    LongDescription = x.LongDescription,
                    CommonName = x.CommonName,
                    Nutrients = x.NutrientDatas.Select(y => new FoodNutrientData()
                    {
                        Name = nutrientTranslations.FirstOrDefault(n => n.NutrientId == y.NutrientId).Description,
                        Value = y.Value,
                        TagName = y.Nutrient.TagName
                    })
                }).ToList();

            return foods;
        }

        public FoodInfo FindFoodInfo(int id)
        {
            var nutrientTranslations = _dbContext.NutrientTranslations
                .Where(x => x.Language.LanguageName == LanguageName && x.Language.CountryName == CountryName);

            var food = _dbContext.Foods
                .Where(x => x.Id == id)
                .Select(x => new FoodInfo()
                {
                    ShortDescription = x.ShortDescription,
                    LongDescription = x.LongDescription,
                    CommonName = x.CommonName,
                    Nutrients = x.NutrientDatas.Select(y => new FoodNutrientData()
                    {
                        Name = nutrientTranslations.FirstOrDefault(n => n.NutrientId == y.NutrientId).Description,
                        Value = y.Value,
                        TagName = y.Nutrient.TagName
                    })
                }).SingleOrDefault();

            return food;
        }
    }
}
