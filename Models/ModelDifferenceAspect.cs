using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ModelDifferenceAspect
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }
        public Nullable<int> Owner_ID { get; set; }
        public virtual ModelDifference ModelDifference { get; set; }
    }
}
