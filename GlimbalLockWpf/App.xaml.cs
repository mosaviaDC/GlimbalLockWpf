using GlimbalLockWpf.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GlimbalLockWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost? _Host;
        private Process process;

        public static IHost Host => _Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);
            await host.StartAsync().ConfigureAwait(false);

            //process = new Process();
            //process.StartInfo.FileName = "GlimbalLock.exe";
            //process.StartInfo.Arguments = "-parentHWND"  + Environment.CommandLine;
            //process.StartInfo.UseShellExecute = true;
            //process.StartInfo.CreateNoWindow = true;

            //process.Start();


        }

        protected override async void OnExit(ExitEventArgs e)
        {



            base.OnExit(e);
            var host = Host;
            await host.StopAsync().ConfigureAwait(false);
        //    process.Kill();
            host.Dispose();
            _Host = null;
        }

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<InputControlViewModel>();
      
            //  services.AddSingleton<IRealTimeStandControlService, RealTimeStandControlService>();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void BundledTheme_ColorChanged(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color> e)
        {

        }
    }
}
