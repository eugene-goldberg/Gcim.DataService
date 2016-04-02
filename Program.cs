using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;
using Topshelf;

namespace SelfHostedWebApiDataService
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //StartConsole();
            //StartServiceBase();
            StartTopshelf();
        }

        static void StartTopshelf()
        {
            HostFactory.Run(x =>
            {
                x.Service<SelfHostedWebApiDataService.TopshelfService>(s =>
                {
                    s.ConstructUsing(name => new SelfHostedWebApiDataService.TopshelfService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Self-Hosted WebAPI Data API Service");
                x.SetDisplayName("WebAPI Data Service");
                x.SetServiceName("WebApiDataApiService");
            });
        }

        static void StartConsole()
        {
            using (WebApp.Start<SelfHostedWebApiDataService.Startup>("http://*:8080"))
            {
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }

        static void StartServiceBase()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SelfHostedWebApiDataService.SelfHostServiceBase()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
