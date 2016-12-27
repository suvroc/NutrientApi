using System;
using System.Collections.Generic;

namespace Nutrients.DataAccess.Models
{
    public partial class DataSource
    {
        public DataSource()
        {
            this.DataSourceLinks = new List<DataSourceLink>();
        }

        public string DataSrc_ID { get; set; }
        public string Authors { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Journal { get; set; }
        public string VolumeCity { get; set; }
        public string IssueState { get; set; }
        public string StartPage { get; set; }
        public string EndPage { get; set; }
        public int Id { get; set; }
        public virtual ICollection<DataSourceLink> DataSourceLinks { get; set; }
    }
}
