namespace SelfHostedWebApiDataService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<AnalyticalMethod> AnalyticalMethods { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntities { get; set; }
        public virtual DbSet<BusinessFunction> BusinessFunctions { get; set; }
        public virtual DbSet<BusinessGoal> BusinessGoals { get; set; }
        public virtual DbSet<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual DbSet<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual DbSet<DataAttribute> DataAttributes { get; set; }
        public virtual DbSet<DataDeliveryMethod> DataDeliveryMethods { get; set; }
        public virtual DbSet<DataEntity> DataEntities { get; set; }
        public virtual DbSet<DataLoadMap> DataLoadMaps { get; set; }
        public virtual DbSet<DataSource> DataSources { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FileData> FileDatas { get; set; }
        public virtual DbSet<Governance> Governances { get; set; }
        public virtual DbSet<HCategory> HCategories { get; set; }
        public virtual DbSet<InformationProduct> InformationProducts { get; set; }
        public virtual DbSet<MasterData> MasterDatas { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public virtual DbSet<ModelDifference> ModelDifferences { get; set; }
        public virtual DbSet<ModuleInfo> ModuleInfoes { get; set; }
        public virtual DbSet<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }
        public virtual DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
        public virtual DbSet<SourceTool> SourceTools { get; set; }
        public virtual DbSet<SubjectArea> SubjectAreas { get; set; }
        public virtual DbSet<TypePermissionObject> TypePermissionObjects { get; set; }
        public virtual DbSet<Udm> Udms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalyticalMethod>()
                .HasMany(e => e.BusinessQuestions)
                .WithOptional(e => e.AnalyticalMethod)
                .HasForeignKey(e => e.AnalyticalMethod_ID);

            modelBuilder.Entity<AnalyticalMethod>()
                .HasMany(e => e.BusinessEntities)
                .WithMany(e => e.AnalyticalMethods)
                .Map(m => m.ToTable("BusinessEntityAnalyticalMethods"));

            modelBuilder.Entity<AnalyticalMethod>()
                .HasMany(e => e.PerformanceMetrics)
                .WithMany(e => e.AnalyticalMethods)
                .Map(m => m.ToTable("PerformanceMetricAnalyticalMethods"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessGoals)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("BusinessGoalBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessInitiatives)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("BusinessInitiativeBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.BusinessQuestions)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("BusinessQuestionBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.DataAttributes)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("DataAttributeBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.DataEntities)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("DataEntityBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.DataSources)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("DataSourceBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.Governances)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("GovernanceBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.InformationProducts)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("InformationProductBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.MasterDatas)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("MasterDataBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.PerformanceMetrics)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("PerformanceMetricBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.SourceTools)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("SourceToolBusinessEntities"));

            modelBuilder.Entity<BusinessEntity>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.BusinessEntities)
                .Map(m => m.ToTable("SubjectAreaBusinessEntities"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.BusinessGoals)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("BusinessFunctionBusinessGoals"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.BusinessInitiatives)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("BusinessInitiativeBusinessFunctions"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.BusinessQuestions)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("BusinessQuestionBusinessFunctions"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("EmployeeBusinessFunctions"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.Governances)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("GovernanceBusinessFunctions"));

            modelBuilder.Entity<BusinessFunction>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.BusinessFunctions)
                .Map(m => m.ToTable("SubjectAreaBusinessFunctions"));

            modelBuilder.Entity<BusinessGoal>()
                .HasMany(e => e.BusinessInitiatives)
                .WithMany(e => e.BusinessGoals)
                .Map(m => m.ToTable("BusinessInitiativeBusinessGoals"));

            modelBuilder.Entity<BusinessGoal>()
                .HasMany(e => e.BusinessQuestions)
                .WithMany(e => e.BusinessGoals)
                .Map(m => m.ToTable("BusinessQuestionBusinessGoals"));

            modelBuilder.Entity<BusinessGoal>()
                .HasMany(e => e.PerformanceMetrics)
                .WithMany(e => e.BusinessGoals)
                .Map(m => m.ToTable("PerformanceMetricBusinessGoals"));

            modelBuilder.Entity<BusinessInitiative>()
                .HasMany(e => e.PerformanceMetrics)
                .WithOptional(e => e.BusinessInitiative)
                .HasForeignKey(e => e.BusinessInitiative_ID);

            modelBuilder.Entity<BusinessInitiative>()
                .HasMany(e => e.SourceTools)
                .WithOptional(e => e.BusinessInitiative)
                .HasForeignKey(e => e.BusinessInitiative_ID);

            modelBuilder.Entity<BusinessInitiative>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.BusinessInitiatives)
                .Map(m => m.ToTable("EmployeeBusinessInitiatives"));

            modelBuilder.Entity<BusinessInitiative>()
                .HasMany(e => e.Governances)
                .WithMany(e => e.BusinessInitiatives)
                .Map(m => m.ToTable("GovernanceBusinessInitiatives"));

            modelBuilder.Entity<BusinessInitiative>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.BusinessInitiatives)
                .Map(m => m.ToTable("SubjectAreaBusinessInitiatives"));

            modelBuilder.Entity<BusinessQuestion>()
                .HasMany(e => e.PerformanceMetrics)
                .WithMany(e => e.BusinessQuestions)
                .Map(m => m.ToTable("BusinessQuestionPerformanceMetrics"));

            modelBuilder.Entity<BusinessQuestion>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.BusinessQuestions)
                .Map(m => m.ToTable("SubjectAreaBusinessQuestions"));

            modelBuilder.Entity<DataAttribute>()
                .HasMany(e => e.DataDeliveryMethods)
                .WithMany(e => e.DataAttributes)
                .Map(m => m.ToTable("DataAttributeDataDeliveryMethods"));

            modelBuilder.Entity<DataAttribute>()
                .HasMany(e => e.DataEntities)
                .WithMany(e => e.DataAttributes)
                .Map(m => m.ToTable("DataEntityDataAttributes"));

            modelBuilder.Entity<DataAttribute>()
                .HasMany(e => e.Udms)
                .WithMany(e => e.DataAttributes)
                .Map(m => m.ToTable("UdmDataAttributes"));

            modelBuilder.Entity<DataDeliveryMethod>()
                .HasMany(e => e.DataSources)
                .WithMany(e => e.DataDeliveryMethods)
                .Map(m => m.ToTable("DataDeliveryMethodDataSources"));

            modelBuilder.Entity<DataDeliveryMethod>()
                .HasMany(e => e.DataEntities)
                .WithMany(e => e.DataDeliveryMethods)
                .Map(m => m.ToTable("DataEntityDataDeliveryMethods"));

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.PerformanceMetrics)
                .WithOptional(e => e.DataEntity)
                .HasForeignKey(e => e.DataEntity_ID);

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.DataSources)
                .WithMany(e => e.DataEntities)
                .Map(m => m.ToTable("DataEntityDataSources"));

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.MasterDatas)
                .WithMany(e => e.DataEntities)
                .Map(m => m.ToTable("MasterDataDataEntities"));

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.SourceTools)
                .WithMany(e => e.DataEntities)
                .Map(m => m.ToTable("SourceToolDataEntities"));

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.DataEntities)
                .Map(m => m.ToTable("SubjectAreaDataEntities"));

            modelBuilder.Entity<DataEntity>()
                .HasMany(e => e.Udms)
                .WithMany(e => e.DataEntities)
                .Map(m => m.ToTable("UdmDataEntities"));

            modelBuilder.Entity<DataSource>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.DataSources)
                .Map(m => m.ToTable("DataSourceEmployees"));

            modelBuilder.Entity<DataSource>()
                .HasMany(e => e.Governances)
                .WithMany(e => e.DataSources)
                .Map(m => m.ToTable("GovernanceDataSources"));

            modelBuilder.Entity<DataSource>()
                .HasMany(e => e.MasterDatas)
                .WithMany(e => e.DataSources)
                .Map(m => m.ToTable("MasterDataDataSources"));

            modelBuilder.Entity<DataSource>()
                .HasMany(e => e.PerformanceMetrics)
                .WithMany(e => e.DataSources)
                .Map(m => m.ToTable("PerformanceMetricDataSources"));

            modelBuilder.Entity<DataSource>()
                .HasMany(e => e.SourceTools)
                .WithMany(e => e.DataSources)
                .Map(m => m.ToTable("SourceToolDataSources"));

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Governances)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("GovernanceEmployees"));

            modelBuilder.Entity<FileData>()
                .HasMany(e => e.DataLoadMaps)
                .WithOptional(e => e.FileData)
                .HasForeignKey(e => e.FieldMapsImportFile_ID);

            modelBuilder.Entity<FileData>()
                .HasMany(e => e.DataLoadMaps1)
                .WithOptional(e => e.FileData1)
                .HasForeignKey(e => e.InputFile_ID);

            modelBuilder.Entity<Governance>()
                .HasMany(e => e.InformationProducts)
                .WithOptional(e => e.Governance)
                .HasForeignKey(e => e.Governance_ID);

            modelBuilder.Entity<Governance>()
                .HasMany(e => e.PerformanceMetrics)
                .WithOptional(e => e.Governance)
                .HasForeignKey(e => e.Governance_ID);

            modelBuilder.Entity<Governance>()
                .HasMany(e => e.SourceTools)
                .WithOptional(e => e.Governance)
                .HasForeignKey(e => e.Governance_ID);

            modelBuilder.Entity<Governance>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.Governances)
                .Map(m => m.ToTable("GovernanceSubjectAreas"));

            modelBuilder.Entity<HCategory>()
                .HasMany(e => e.HCategories1)
                .WithOptional(e => e.HCategory1)
                .HasForeignKey(e => e.Parent_ID);

            modelBuilder.Entity<InformationProduct>()
                .HasMany(e => e.AnalyticalMethods)
                .WithOptional(e => e.InformationProduct)
                .HasForeignKey(e => e.InformationProduct_ID);

            modelBuilder.Entity<InformationProduct>()
                .HasMany(e => e.DataEntities)
                .WithOptional(e => e.InformationProduct)
                .HasForeignKey(e => e.InformationProduct_ID);

            modelBuilder.Entity<InformationProduct>()
                .HasMany(e => e.SourceTools)
                .WithMany(e => e.InformationProducts)
                .Map(m => m.ToTable("InformationProductSourceTools"));

            modelBuilder.Entity<MasterData>()
                .HasMany(e => e.SourceTools)
                .WithMany(e => e.MasterDatas)
                .Map(m => m.ToTable("SourceToolMasterDatas"));

            modelBuilder.Entity<ModelDifference>()
                .HasMany(e => e.ModelDifferenceAspects)
                .WithOptional(e => e.ModelDifference)
                .HasForeignKey(e => e.Owner_ID);

            modelBuilder.Entity<PerformanceMetric>()
                .HasMany(e => e.InformationProducts)
                .WithOptional(e => e.PerformanceMetric)
                .HasForeignKey(e => e.PerformanceMetric_ID);

            modelBuilder.Entity<PerformanceMetric>()
                .HasMany(e => e.SubjectAreas)
                .WithMany(e => e.PerformanceMetrics)
                .Map(m => m.ToTable("SubjectAreaPerformanceMetrics"));

            modelBuilder.Entity<Role>()
                .HasMany(e => e.TypePermissionObjects)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Role_ID);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Roles1)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("RoleRoles").MapRightKey("Role_ID1"));

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles"));

            modelBuilder.Entity<SourceTool>()
                .HasMany(e => e.Udms)
                .WithMany(e => e.SourceTools)
                .Map(m => m.ToTable("UdmSourceTools"));

            modelBuilder.Entity<TypePermissionObject>()
                .HasMany(e => e.SecuritySystemMemberPermissionsObjects)
                .WithOptional(e => e.TypePermissionObject)
                .HasForeignKey(e => e.Owner_ID);

            modelBuilder.Entity<TypePermissionObject>()
                .HasMany(e => e.SecuritySystemObjectPermissionsObjects)
                .WithOptional(e => e.TypePermissionObject)
                .HasForeignKey(e => e.Owner_ID);
        }
    }
}
