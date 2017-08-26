using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace WinMarketServiceHost
{
    [RunInstaller(true)]
    public partial class ContextServiceInstaller : System.Configuration.Install.Installer
    {
        public ContextServiceInstaller()
        {
            InitializeComponent();

            ServiceProcessInstaller processInstaller = new ServiceProcessInstaller();
            processInstaller.Account = ServiceAccount.NetworkService;

            ServiceInstaller serviceInstaller = new ServiceInstaller();
            serviceInstaller.ServiceName = "ContextHostWindowsService";

            serviceInstaller.DisplayName = "ContextHostWindowsService";
            serviceInstaller.Description = "Context WCF Service Hosted Successfully.";
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);

        }
    }
}
