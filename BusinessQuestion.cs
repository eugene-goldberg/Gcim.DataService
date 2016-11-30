namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessQuestion()
        {
            BusinessEntities = new HashSet<BusinessEntity>();
            BusinessFunctions = new HashSet<BusinessFunction>();
            BusinessGoals = new HashSet<BusinessGoal>();
            PerformanceMetrics = new HashSet<PerformanceMetric>();
            SubjectAreas = new HashSet<SubjectArea>();
        }

        public int ID { get; set; }

        public string QuestionDefinition { get; set; }

        public string Comments { get; set; }

        public string RelatedSubjectArea { get; set; }

        public int? AnalyticalMethod_ID { get; set; }

        public virtual AnalyticalMethod AnalyticalMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
