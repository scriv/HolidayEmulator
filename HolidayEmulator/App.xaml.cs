using Caliburn.Micro;
using HolidayEmulator.EndPoint;
using HolidayEmulator.Messages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;

namespace HolidayEmulator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static readonly IEventAggregator EventAggregator = new EventAggregator();
        private ServiceHost host;

        protected override void OnStartup(StartupEventArgs e)
        {
            this.host = new ServiceHost(typeof(HolidayEndPoint));
            this.host.Open();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            if (this.host != null)
            {
                this.host.Close();
            }
        }
    }
}