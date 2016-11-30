namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModelDifferenceAspect
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Xml { get; set; }

        public int? Owner_ID { get; set; }

        public virtual ModelDifference ModelDifference { get; set; }
    }
}
