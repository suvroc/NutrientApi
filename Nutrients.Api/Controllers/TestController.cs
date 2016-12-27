using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nutrients.Api.Controllers
{
    public class TestController : ApiController
    {
        public int Test()
        {
            return 12;
        }
    }
}
