namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AnalyticalMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnalyticalMethod()
        {
            BusinessQuestions = new HashSet<BusinessQuestion>();
            BusinessEntities = new HashSet<BusinessEntity>();
            PerformanceMetrics = new HashSet<PerformanceMetric>();
        }

        public int ID { get; set; }

        public string MethodName { get; set; }

        public string Description { get; set; }

        public int? InformationProduct_ID { get; set; }

        public string Calculation { get; set; }

        public virtual InformationProduct InformationProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
    }
}
