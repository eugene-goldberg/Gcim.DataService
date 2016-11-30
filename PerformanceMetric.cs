namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PerformanceMetric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerformanceMetric()
        {
            InformationProducts = new HashSet<InformationProduct>();
            BusinessQuestions = new HashSet<BusinessQuestion>();
            AnalyticalMethods = new HashSet<AnalyticalMethod>();
            BusinessEntities = new HashSet<BusinessEntity>();
            BusinessGoals = new HashSet<BusinessGoal>();
            DataSources = new HashSet<DataSource>();
            SubjectAreas = new HashSet<SubjectArea>();
        }

        public int ID { get; set; }

        public string Category { get; set; }

        public string MetricName { get; set; }

        public string MetricDefinition { get; set; }

        public string Description { get; set; }

        public int? DataEntity_ID { get; set; }

        public int? Governance_ID { get; set; }

        public int? BusinessInitiative_ID { get; set; }

        public virtual BusinessInitiative BusinessInitiative { get; set; }

        public virtual DataEntity DataEntity { get; set; }

        public virtual Governance Governance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformationProduct> InformationProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnalyticalMethod> AnalyticalMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataSource> DataSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
