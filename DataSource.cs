namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSource()
        {
            DataDeliveryMethods = new HashSet<DataDeliveryMethod>();
            DataEntities = new HashSet<DataEntity>();
            BusinessEntities = new HashSet<BusinessEntity>();
            Employees = new HashSet<Employee>();
            Governances = new HashSet<Governance>();
            MasterDatas = new HashSet<MasterData>();
            PerformanceMetrics = new HashSet<PerformanceMetric>();
            SourceTools = new HashSet<SourceTool>();
        }

        public int ID { get; set; }

        public string Category { get; set; }

        public string SourceSystemName { get; set; }

        public string SourceSystemOwner { get; set; }

        public string SourceSystemLocation { get; set; }

        public string SourceSystemTeam { get; set; }

        public string SourceSystemNetworkSegment { get; set; }

        public string SourceSystemOsType { get; set; }

        public string SourceDatabaseName { get; set; }

        public string SourceDatabaseType { get; set; }

        public string SourceDatabaseVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataDeliveryMethod> DataDeliveryMethods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataEntity> DataEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Governance> Governances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterData> MasterDatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SourceTool> SourceTools { get; set; }
    }
}
