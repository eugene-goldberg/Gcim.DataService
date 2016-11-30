namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModelDifference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelDifference()
        {
            ModelDifferenceAspects = new HashSet<ModelDifferenceAspect>();
        }

        public int ID { get; set; }

        public string UserId { get; set; }

        public string ContextId { get; set; }

        public int Version { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
    }
}
