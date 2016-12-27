

using StructureMap;

namespace Nutrients.WebApi.StructureMap
{
    public class DefaultRegistry : Registry
    {
        #region Constructors and Destructors

        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    //scan.AddAllTypesOf(typeof(IModelValidator<>));
                });
        }

        #endregion
    }
}