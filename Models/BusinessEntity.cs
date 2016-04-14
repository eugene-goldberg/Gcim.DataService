using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            this.AnalyticalMethods = new List<AnalyticalMethod>();
            this.BusinessGoals = new List<BusinessGoal>();
            this.BusinessInitiatives = new List<BusinessInitiative>();
            this.BusinessQuestions = new List<BusinessQuestion>();
            this.DataEntities = new List<DataEntity>();
            this.DataSources = new List<DataSource>();
            this.Governances = new List<Governance>();
            this.InformationProducts = new List<InformationProduct>();
            this.MasterDatas = new List<MasterData>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.SourceTools = new List<SourceTool>();
            this.SubjectAreas = new List<SubjectArea>();
            this.UdmDataAttributes = new List<UdmDataAttribute>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AnalyticalMethod> AnalyticalMethods { get; set; }
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }
        public virtual ICollection<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
        public virtual ICollection<InformationProduct> InformationProducts { get; set; }
        public virtual ICollection<MasterData> MasterDatas { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
        public virtual ICollection<UdmDataAttribute> UdmDataAttributes { get; set; }
    }
}
