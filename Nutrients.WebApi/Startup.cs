using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Nutrients.IoC.DependencyResolution;
using Nutrients.WebApi;
using Nutrients.WebApi.App_Start;
using Nutrients.WebApi.StructureMap;
using Owin;
using StructureMap;

[assembly: OwinStartup(typeof(Startup))]
namespace Nutrients.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Configuration(app, IoC.DependencyResolution.IoC.Initialize(new DefaultRegistry()));
        }

        public HttpConfiguration Configuration(IAppBuilder app, IContainer container)
        {
            var config = new HttpConfiguration();

            config.EnableCors(new EnableCorsAttribute("*", "*", "GET, PUT, POST, DELETE, HEAD, OPTIONS"));

            config.DependencyResolver = new StructureMapWebApiDependencyResolver(container);

            //ConfigureOAuth(app);

            //FilterConfig.Register(container, config);

            WebApiConfig.Register(config);
            SwaggerConfig.Register(config);

            AutoMapperWebApiConfiguration.Configure();

            app.UseWebApi(config);

            return config;
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
