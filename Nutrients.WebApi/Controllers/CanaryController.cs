using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Nutrients.WebApi.Models;

namespace Nutrients.WebApi.Controllers
{
    public class CanaryController : ApiController
    {
        [Route("api/canary/Info")]
        [ResponseType(typeof(ApiInfo))]
        public IHttpActionResult Info()
        {
            ApiInfo info = new ApiInfo();

            bool showVersionInfo;
            //bool.TryParse(ConfigurationManager.AppSettings[Constants.AppSettingsKeys.ApplicationShowVersionInfo], out showVersionInfo);
            //info.ShowVersionInfo = showVersionInfo;

            //if (showVersionInfo)
            {
                var con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["NutrientDbContext"].ConnectionString);

               // info.Environment = ConfigurationManager.AppSettings[Constants.AppSettingsKeys.ApplicationEnvironment];
               // info.Branch = ConfigurationManager.AppSettings[Constants.AppSettingsKeys.ApplicationBranch];
               // info.ReleaseNumber = ConfigurationManager.AppSettings[Constants.AppSettingsKeys.ApplicationReleaseNumber];
                info.MachineName = Environment.MachineName;
                info.DatabaseName = con.InitialCatalog;
                info.DatabaseSource = con.DataSource;
            }

            return Ok(info);
        }
    }
}
