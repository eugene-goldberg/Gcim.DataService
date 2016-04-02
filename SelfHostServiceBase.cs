using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;

namespace SelfHostedWebApiDataService
{
    public partial class SelfHostServiceBase : ServiceBase
    {
        private IDisposable _webapp;

        public SelfHostServiceBase()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _webapp = WebApp.Start<SelfHostedWebApiDataService.Startup>("http://*:8080");
        }

        protected override void OnStop()
        {
            //_webapp?.Dispose();
        }
    }
}
