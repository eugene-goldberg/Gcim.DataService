using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Udm
    {
        public Udm()
        {
            this.DataAttributes = new List<DataAttribute>();
            this.DataEntities = new List<DataEntity>();
            this.SourceTools = new List<SourceTool>();
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string InstanceName { get; set; }
        public virtual ICollection<DataAttribute> DataAttributes { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
    }
}
