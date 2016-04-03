using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using Nancy;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using SelfHostedWebApiDataService.Models;

namespace SelfHostedWebApiDataService
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<SubjectArea>("SubjectArea");
            builder.EntitySet<BusinessEntity>("BusinessEntity");
            builder.EntitySet<ChangeRecord>("ChangeRecord");
            builder.EntitySet<AnalyticalMethod>("AnalyticalMethod");
            builder.EntitySet<BusinessFunction>("BusinessFunction");
            builder.EntitySet<BusinessGoal>("BusinessGoal");
            builder.EntitySet<BusinessInitiative>("BusinessInitiative");
            builder.EntitySet<BusinessQuestion>("BusinessQuestion");
            builder.EntitySet<DataAttribute>("DataAttribute");
            builder.EntitySet<DataDeliveryMethod>("DataDeliveryMethod");
            builder.EntitySet<DataEntity>("DataEntity");
            builder.EntitySet<DataLoadMap>("DataLoadMap");
            builder.EntitySet<DataSource>("DataSource");
            builder.EntitySet<Employee>("Employee");
            builder.EntitySet<Governance>("Governance");
            builder.EntitySet<InformationProduct>("InformationProduct");
            builder.EntitySet<MasterData>("MasterData");
            builder.EntitySet<PerformanceMetric>("PerformanceMetric");
            builder.EntitySet<SourceTool>("SourceTool");
            builder.EntitySet<Udm>("Udm");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());


            // Adding to the pipeline with our own middleware
            app.Use(async (context, next) =>
            {
                // Add Header
                context.Response.Headers["Product"] = "Web Api Self Host";

                // Call next middleware
                await next.Invoke();
            });
            
            // Custom Middleare
            app.Use(typeof(SelfHostedWebApiDataService.CustomMiddleware));
            
            // Web Api
            app.UseWebApi(config);

            // File Server
            var options = new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                EnableDefaultFiles = true,
                DefaultFilesOptions = { DefaultFileNames = {"index.html"}},
                FileSystem = new PhysicalFileSystem("Assets"),
                StaticFileOptions = { ContentTypeProvider = new SelfHostedWebApiDataService.CustomContentTypeProvider() }
            };

            app.UseFileServer(options);

            // Nancy
            app.UseNancy();
        }
    }
}
