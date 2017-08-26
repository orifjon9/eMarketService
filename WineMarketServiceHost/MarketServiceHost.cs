using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MarketService;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WinMarketServiceHost
{
    public partial class MarketServiceHost : ServiceBase
    {
        ServiceHost marketServiceHost = null;
        public MarketServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                Uri httpBaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["ServiceUrl"]);
                marketServiceHost = new ServiceHost(typeof(ContextService), httpBaseAddress);

                marketServiceHost.AddServiceEndpoint(typeof(IContextService), new WSHttpBinding(), "");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpsGetEnabled = true;

                marketServiceHost.Description.Behaviors.Add(serviceMetadataBehavior);

                marketServiceHost.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                marketServiceHost = null;
            }
        }

        protected override void OnStop()
        {
            if (marketServiceHost != null)
            {
                marketServiceHost.Close();
                marketServiceHost = null;
            }
        }
    }
}
