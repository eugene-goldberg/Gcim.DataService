using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SelfHostedWebApiDataService.Models.Mapping;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GCIMContext : DbContext
    {
        static GCIMContext()
        {
            Database.SetInitializer<GCIMContext>(null);
        }

        public GCIMContext()
            : base("Name=GCIMContext")
        {
        }

        public DbSet<AnalyticalMethod> AnalyticalMethods { get; set; }
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<BusinessFunction> BusinessFunctions { get; set; }
        public DbSet<BusinessGoal> BusinessGoals { get; set; }
        public DbSet<BusinessInitiative> BusinessInitiatives { get; set; }
        public DbSet<BusinessQuestion> BusinessQuestions { get; set; }
        public DbSet<ChangeRecord> ChangeRecords { get; set; }
        public DbSet<DataAttribute> DataAttributes { get; set; }
        public DbSet<DataDeliveryMethod> DataDeliveryMethods { get; set; }
        public DbSet<DataEntity> DataEntities { get; set; }
        public DbSet<DataLoadMap> DataLoadMaps { get; set; }
        public DbSet<DataSource> DataSources { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FileData> FileDatas { get; set; }
        public DbSet<Governance> Governances { get; set; }
        public DbSet<HCategory> HCategories { get; set; }
        public DbSet<InformationProduct> InformationProducts { get; set; }
        public DbSet<MasterData> MasterDatas { get; set; }
        public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public DbSet<ModelDifference> ModelDifferences { get; set; }
        public DbSet<ModuleInfo> ModuleInfoes { get; set; }
        public DbSet<PerformanceMetric> PerformanceMetrics { get; set; }
        public DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }
        public DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
        public DbSet<SourceTool> SourceTools { get; set; }
        public DbSet<SubjectArea> SubjectAreas { get; set; }
        public DbSet<TypePermissionObject> TypePermissionObjects { get; set; }
        public DbSet<Udm> Udms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnalyticalMethodMap());
            modelBuilder.Configurations.Add(new BusinessEntityMap());
            modelBuilder.Configurations.Add(new BusinessFunctionMap());
            modelBuilder.Configurations.Add(new BusinessGoalMap());
            modelBuilder.Configurations.Add(new BusinessInitiativeMap());
            modelBuilder.Configurations.Add(new BusinessQuestionMap());
            modelBuilder.Configurations.Add(new ChangeRecordMap());
            modelBuilder.Configurations.Add(new DataAttributeMap());
            modelBuilder.Configurations.Add(new DataDeliveryMethodMap());
            modelBuilder.Configurations.Add(new DataEntityMap());
            modelBuilder.Configurations.Add(new DataLoadMapMap());
            modelBuilder.Configurations.Add(new DataSourceMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new FileDataMap());
            modelBuilder.Configurations.Add(new GovernanceMap());
            modelBuilder.Configurations.Add(new HCategoryMap());
            modelBuilder.Configurations.Add(new InformationProductMap());
            modelBuilder.Configurations.Add(new MasterDataMap());
            modelBuilder.Configurations.Add(new ModelDifferenceAspectMap());
            modelBuilder.Configurations.Add(new ModelDifferenceMap());
            modelBuilder.Configurations.Add(new ModuleInfoMap());
            modelBuilder.Configurations.Add(new PerformanceMetricMap());
            modelBuilder.Configurations.Add(new ReportDataV2Map());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SecuritySystemMemberPermissionsObjectMap());
            modelBuilder.Configurations.Add(new SecuritySystemObjectPermissionsObjectMap());
            modelBuilder.Configurations.Add(new SourceToolMap());
            modelBuilder.Configurations.Add(new SubjectAreaMap());
            modelBuilder.Configurations.Add(new TypePermissionObjectMap());
            modelBuilder.Configurations.Add(new UdmMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
