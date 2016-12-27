using AutoMapper;

namespace Nutrients.WebApi.App_Start
{
    public class AutoMapperWebApiConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(GetConfiguration);
        }

        private static void GetConfiguration(IMapperConfigurationExpression configuration)
        {
        }
    }
}