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

        [Route("Info")]
        public FoodInfo FindFoodInfo(string searchText)
        {
            return _foodService.FindFoodInfo(searchText);
        }
    }
}
