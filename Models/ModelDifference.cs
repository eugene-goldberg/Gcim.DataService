using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ModelDifference
    {
        public ModelDifference()
        {
            this.ModelDifferenceAspects = new List<ModelDifferenceAspect>();
        }

        public int ID { get; set; }
        public string UserId { get; set; }
        public string ContextId { get; set; }
        public int Version { get; set; }
        public virtual ICollection<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
    }
}
