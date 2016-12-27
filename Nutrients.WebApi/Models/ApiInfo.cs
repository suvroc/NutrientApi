using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrients.WebApi.Models
{
    public class ApiInfo
    {
        public bool ShowVersionInfo { get; set; }

        public string Environment { get; set; }

        public string Branch { get; set; }

        public string ReleaseNumber { get; set; }

        public string DatabaseName { get; set; }

        public string DatabaseSource { get; set; }

        public string MachineName { get; set; }
    }
}