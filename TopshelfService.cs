using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SelfHostedWebApiDataService
{
    public class TopshelfService
    {
        private IDisposable _webapp;

        public void Start()
        {
            _webapp = WebApp.Start<SelfHostedWebApiDataService.Startup>("http://*:8888");
        }

        public void Stop()
        {
           // _webapp?.Dispose();
        }
    }
}
