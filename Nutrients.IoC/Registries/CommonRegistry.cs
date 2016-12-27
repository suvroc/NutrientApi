using Nutrients.DataAccess;
using Nutrients.Domain.Food;

namespace Nutrients.IoC.Registries
{
    public class CommonRegistry : StructureMap.Registry
    {
        #region Constructors and Destructors

        public CommonRegistry()
        {
            Scan(
                scan =>
                {
                    scan.AssemblyContainingType<NutrientDbContext>();
                    scan.AssemblyContainingType<FoodService>();
                    scan.WithDefaultConventions();
                });
        }

        #endregion
    }
}
