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

                x.SetDescription("Common Data Service");
                x.SetDisplayName("Common Data Service");
                x.SetServiceName("GommonDataService");
            });
        }

        static void StartConsole()
        {
            using (WebApp.Start<SelfHostedWebApiDataService.Startup>("http://*:8888"))
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
