using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SelfHostedWebApiDataService.Models.Mapping;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataExplorerContext : DbContext
    {
        static DataExplorerContext()
        {
            Database.SetInitializer<DataExplorerContext>(null);
        }

        public DataExplorerContext()
            : base("Name=DataExplorerContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Analysis> Analyses { get; set; }
        public DbSet<AnalyticalMethod> AnalyticalMethods { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<BusinessFunction> BusinessFunctions { get; set; }
        public DbSet<BusinessGoal> BusinessGoals { get; set; }
        public DbSet<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions> BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public DbSet<BusinessInitiative> BusinessInitiatives { get; set; }
        public DbSet<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals> BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals { get; set; }
        public DbSet<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction> BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction { get; set; }
        public DbSet<BusinessQuestion> BusinessQuestions { get; set; }
        public DbSet<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions> BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public DbSet<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals> BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals { get; set; }
        public DbSet<DataDeliveryActivity> DataDeliveryActivities { get; set; }
        public DbSet<DataDeliveryChannel> DataDeliveryChannels { get; set; }
        public DbSet<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals> DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals { get; set; }
        public DbSet<DataDeliveryMethod> DataDeliveryMethods { get; set; }
        public DbSet<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel> DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel { get; set; }
        public DbSet<DataDictionaryItem> DataDictionaryItems { get; set; }
        public DbSet<DataDiscoveryMethod> DataDiscoveryMethods { get; set; }
        public DbSet<DataFormat> DataFormats { get; set; }
        public DbSet<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels> DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels { get; set; }
        public DbSet<DataLoadMap> DataLoadMaps { get; set; }
        public DbSet<DataSource> DataSources { get; set; }
        public DbSet<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels> DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels { get; set; }
        public DbSet<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource> DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource { get; set; }
        public DbSet<DataTable> DataTables { get; set; }
        public DbSet<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems> DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems { get; set; }
        public DbSet<DataTableAssociatedDataTables_DataSourceAssociatedDataSources> DataTableAssociatedDataTables_DataSourceAssociatedDataSources { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions> EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions { get; set; }
        public DbSet<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives> EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives { get; set; }
        public DbSet<EmployeeDataSourceOwners_DataSourceOwnsDatasources> EmployeeDataSourceOwners_DataSourceOwnsDatasources { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityAssociatedEntities_DataTableAssociatedDataTables> EntityAssociatedEntities_DataTableAssociatedDataTables { get; set; }
        public DbSet<EntityAttributeEntities_AttributeEntityAttributes> EntityAttributeEntities_AttributeEntityAttributes { get; set; }
        public DbSet<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources> EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources { get; set; }
        public DbSet<EntityOwnedEntities_EmployeeEntityOwners> EntityOwnedEntities_EmployeeEntityOwners { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FieldMap> FieldMaps { get; set; }
        public DbSet<FileData> FileDatas { get; set; }
        public DbSet<GambiTool> GambiTools { get; set; }
        public DbSet<GambiToolOwnsGambiTools_EmployeeToolOwners> GambiToolOwnsGambiTools_EmployeeToolOwners { get; set; }
        public DbSet<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives> GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives { get; set; }
        public DbSet<GambiToolSupportedGambiTools_DataSourceSupportingDataSources> GambiToolSupportedGambiTools_DataSourceSupportingDataSources { get; set; }
        public DbSet<GambiToolUsedInGambiTools_EntityReliesOnEntities> GambiToolUsedInGambiTools_EntityReliesOnEntities { get; set; }
        public DbSet<Governance> Governances { get; set; }
        public DbSet<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives> GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives { get; set; }
        public DbSet<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions> GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions { get; set; }
        public DbSet<GovernanceGovernsOver_EmployeeGoverningEmployees> GovernanceGovernsOver_EmployeeGoverningEmployees { get; set; }
        public DbSet<HCategory> HCategories { get; set; }
        public DbSet<InformationComponent> InformationComponents { get; set; }
        public DbSet<InformationComponentRelatedInformationComponents_EntityRelatedEntities> InformationComponentRelatedInformationComponents_EntityRelatedEntities { get; set; }
        public DbSet<KpiDefinition> KpiDefinitions { get; set; }
        public DbSet<KpiHistoryItem> KpiHistoryItems { get; set; }
        public DbSet<KpiInstance> KpiInstances { get; set; }
        public DbSet<KpiScorecard> KpiScorecards { get; set; }
        public DbSet<KpiScorecardScorecards_KpiInstanceIndicators> KpiScorecardScorecards_KpiInstanceIndicators { get; set; }
        public DbSet<MasterData> MasterDatas { get; set; }
        public DbSet<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources> MasterDataAssociatedMasterData_DataSourceAssociatedDataSources { get; set; }
        public DbSet<MasterDataAssociatedMasterData_DataTableAssociatedDataTables> MasterDataAssociatedMasterData_DataTableAssociatedDataTables { get; set; }
        public DbSet<MasterDataAssociatedMasterData_EntityAssociatedEntities> MasterDataAssociatedMasterData_EntityAssociatedEntities { get; set; }
        public DbSet<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools> MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools { get; set; }
        public DbSet<MetricCalculation> MetricCalculations { get; set; }
        public DbSet<MetricMockup> MetricMockups { get; set; }
        public DbSet<ModuleInfo> ModuleInfoes { get; set; }
        public DbSet<ObjectField> ObjectFields { get; set; }
        public DbSet<PerformanceMetric> PerformanceMetrics { get; set; }
        public DbSet<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal> PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal { get; set; }
        public DbSet<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives> PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives { get; set; }
        public DbSet<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods> PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods { get; set; }
        public DbSet<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations> PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations { get; set; }
        public DbSet<PerformanceMetricMockupForMetric_MetricMockupMetricMockups> PerformanceMetricMockupForMetric_MetricMockupMetricMockups { get; set; }
        public DbSet<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods> PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods { get; set; }
        public DbSet<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions> PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions { get; set; }
        public DbSet<PerformanceMetricTrackingMethod> PerformanceMetricTrackingMethods { get; set; }
        public DbSet<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked> PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked { get; set; }
        public DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceResources_EventEvents> ResourceResources_EventEvents { get; set; }
        public DbSet<SalesforcePipeline> SalesforcePipelines { get; set; }
        public DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }
        public DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
        public DbSet<SecuritySystemRole> SecuritySystemRoles { get; set; }
        public DbSet<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles> SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles { get; set; }
        public DbSet<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObjects { get; set; }
        public DbSet<SecuritySystemUser> SecuritySystemUsers { get; set; }
        public DbSet<SecuritySystemUserUsers_SecuritySystemRoleRoles> SecuritySystemUserUsers_SecuritySystemRoleRoles { get; set; }
        public DbSet<SubjectArea> SubjectAreas { get; set; }
        public DbSet<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions> SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public DbSet<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives> SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives { get; set; }
        public DbSet<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities> SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities { get; set; }
        public DbSet<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy> SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy { get; set; }
        public DbSet<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents> SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents { get; set; }
        public DbSet<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions> SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions { get; set; }
        public DbSet<Synonim> Synonims { get; set; }
        public DbSet<SynonimEntitySynonims_EntitySynonimEntities> SynonimEntitySynonims_EntitySynonimEntities { get; set; }
        public DbSet<XPObjectType> XPObjectTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AnalysisMap());
            modelBuilder.Configurations.Add(new AnalyticalMethodMap());
            modelBuilder.Configurations.Add(new AttributeMap());
            modelBuilder.Configurations.Add(new BusinessFunctionMap());
            modelBuilder.Configurations.Add(new BusinessGoalMap());
            modelBuilder.Configurations.Add(new BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctionsMap());
            modelBuilder.Configurations.Add(new BusinessInitiativeMap());
            modelBuilder.Configurations.Add(new BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoalsMap());
            modelBuilder.Configurations.Add(new BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunctionMap());
            modelBuilder.Configurations.Add(new BusinessQuestionMap());
            modelBuilder.Configurations.Add(new BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctionsMap());
            modelBuilder.Configurations.Add(new BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoalsMap());
            modelBuilder.Configurations.Add(new DataDeliveryActivityMap());
            modelBuilder.Configurations.Add(new DataDeliveryChannelMap());
            modelBuilder.Configurations.Add(new DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoalsMap());
            modelBuilder.Configurations.Add(new DataDeliveryMethodMap());
            modelBuilder.Configurations.Add(new DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannelMap());
            modelBuilder.Configurations.Add(new DataDictionaryItemMap());
            modelBuilder.Configurations.Add(new DataDiscoveryMethodMap());
            modelBuilder.Configurations.Add(new DataFormatMap());
            modelBuilder.Configurations.Add(new DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannelsMap());
            modelBuilder.Configurations.Add(new DataLoadMapMap());
            modelBuilder.Configurations.Add(new DataSourceMap());
            modelBuilder.Configurations.Add(new DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannelsMap());
            modelBuilder.Configurations.Add(new DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSourceMap());
            modelBuilder.Configurations.Add(new DataTableMap());
            modelBuilder.Configurations.Add(new DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItemsMap());
            modelBuilder.Configurations.Add(new DataTableAssociatedDataTables_DataSourceAssociatedDataSourcesMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntionsMap());
            modelBuilder.Configurations.Add(new EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiativesMap());
            modelBuilder.Configurations.Add(new EmployeeDataSourceOwners_DataSourceOwnsDatasourcesMap());
            modelBuilder.Configurations.Add(new EntityMap());
            modelBuilder.Configurations.Add(new EntityAssociatedEntities_DataTableAssociatedDataTablesMap());
            modelBuilder.Configurations.Add(new EntityAttributeEntities_AttributeEntityAttributesMap());
            modelBuilder.Configurations.Add(new EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSourcesMap());
            modelBuilder.Configurations.Add(new EntityOwnedEntities_EmployeeEntityOwnersMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new FieldMapMap());
            modelBuilder.Configurations.Add(new FileDataMap());
            modelBuilder.Configurations.Add(new GambiToolMap());
            modelBuilder.Configurations.Add(new GambiToolOwnsGambiTools_EmployeeToolOwnersMap());
            modelBuilder.Configurations.Add(new GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiativesMap());
            modelBuilder.Configurations.Add(new GambiToolSupportedGambiTools_DataSourceSupportingDataSourcesMap());
            modelBuilder.Configurations.Add(new GambiToolUsedInGambiTools_EntityReliesOnEntitiesMap());
            modelBuilder.Configurations.Add(new GovernanceMap());
            modelBuilder.Configurations.Add(new GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiativesMap());
            modelBuilder.Configurations.Add(new GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctionsMap());
            modelBuilder.Configurations.Add(new GovernanceGovernsOver_EmployeeGoverningEmployeesMap());
            modelBuilder.Configurations.Add(new HCategoryMap());
            modelBuilder.Configurations.Add(new InformationComponentMap());
            modelBuilder.Configurations.Add(new InformationComponentRelatedInformationComponents_EntityRelatedEntitiesMap());
            modelBuilder.Configurations.Add(new KpiDefinitionMap());
            modelBuilder.Configurations.Add(new KpiHistoryItemMap());
            modelBuilder.Configurations.Add(new KpiInstanceMap());
            modelBuilder.Configurations.Add(new KpiScorecardMap());
            modelBuilder.Configurations.Add(new KpiScorecardScorecards_KpiInstanceIndicatorsMap());
            modelBuilder.Configurations.Add(new MasterDataMap());
            modelBuilder.Configurations.Add(new MasterDataAssociatedMasterData_DataSourceAssociatedDataSourcesMap());
            modelBuilder.Configurations.Add(new MasterDataAssociatedMasterData_DataTableAssociatedDataTablesMap());
            modelBuilder.Configurations.Add(new MasterDataAssociatedMasterData_EntityAssociatedEntitiesMap());
            modelBuilder.Configurations.Add(new MasterDataAssociatedMasterData_GambiToolAssociatedGambiToolsMap());
            modelBuilder.Configurations.Add(new MetricCalculationMap());
            modelBuilder.Configurations.Add(new MetricMockupMap());
            modelBuilder.Configurations.Add(new ModuleInfoMap());
            modelBuilder.Configurations.Add(new ObjectFieldMap());
            modelBuilder.Configurations.Add(new PerformanceMetricMap());
            modelBuilder.Configurations.Add(new PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoalMap());
            modelBuilder.Configurations.Add(new PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiativesMap());
            modelBuilder.Configurations.Add(new PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethodsMap());
            modelBuilder.Configurations.Add(new PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculationsMap());
            modelBuilder.Configurations.Add(new PerformanceMetricMockupForMetric_MetricMockupMetricMockupsMap());
            modelBuilder.Configurations.Add(new PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethodsMap());
            modelBuilder.Configurations.Add(new PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestionsMap());
            modelBuilder.Configurations.Add(new PerformanceMetricTrackingMethodMap());
            modelBuilder.Configurations.Add(new PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTrackedMap());
            modelBuilder.Configurations.Add(new ReportDataV2Map());
            modelBuilder.Configurations.Add(new ResourceMap());
            modelBuilder.Configurations.Add(new ResourceResources_EventEventsMap());
            modelBuilder.Configurations.Add(new SalesforcePipelineMap());
            modelBuilder.Configurations.Add(new SecuritySystemMemberPermissionsObjectMap());
            modelBuilder.Configurations.Add(new SecuritySystemObjectPermissionsObjectMap());
            modelBuilder.Configurations.Add(new SecuritySystemRoleMap());
            modelBuilder.Configurations.Add(new SecuritySystemRoleParentRoles_SecuritySystemRoleChildRolesMap());
            modelBuilder.Configurations.Add(new SecuritySystemTypePermissionsObjectMap());
            modelBuilder.Configurations.Add(new SecuritySystemUserMap());
            modelBuilder.Configurations.Add(new SecuritySystemUserUsers_SecuritySystemRoleRolesMap());
            modelBuilder.Configurations.Add(new SubjectAreaMap());
            modelBuilder.Configurations.Add(new SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctionsMap());
            modelBuilder.Configurations.Add(new SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiativesMap());
            modelBuilder.Configurations.Add(new SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntitiesMap());
            modelBuilder.Configurations.Add(new SubjectAreaGovernedSubjectAreas_GovernanceGovernedByMap());
            modelBuilder.Configurations.Add(new SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponentsMap());
            modelBuilder.Configurations.Add(new SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestionsMap());
            modelBuilder.Configurations.Add(new SynonimMap());
            modelBuilder.Configurations.Add(new SynonimEntitySynonims_EntitySynonimEntitiesMap());
            modelBuilder.Configurations.Add(new XPObjectTypeMap());
        }
    }
}
