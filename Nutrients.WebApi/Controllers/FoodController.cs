using System.Collections.Generic;
using System.Web.Http;
using Nutrients.Domain.Food;
using Nutrients.Domain.Food.Models;

namespace Nutrients.WebApi.Controllers
{
    [RoutePrefix("Food")]
    public class FoodController : ApiController
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        [Route("Search/{searchText}")]
        public List<Food> FindFood(string searchText)
        {
            return _foodService.FindFood(searchText);
        }

        [HttpGet]
        [Route("{searchText}")]
        public List<FoodInfo> FindFoodInfo(string searchText)
        {
            return _foodService.FindFoodInfo(searchText);
        }

        [HttpGet]
        [Route("Id/{id}")]
        public FoodInfo FindFoodInfoById(int id)
        {
            return _foodService.FindFoodInfo(id);
        }

        [Route("Test")]
        public int Test()
        {
            return 12;
        }
    }
}
