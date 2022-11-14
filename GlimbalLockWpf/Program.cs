using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlimbalLockWpf
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] Args)
        {
            var builder = Host.CreateDefaultBuilder(Args);
            //Настройка HostBuilder
            builder.UseContentRoot(Environment.CurrentDirectory);
            builder.ConfigureAppConfiguration((host, config) =>
            {
                config.SetBasePath(Environment.CurrentDirectory);
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            });
            builder.ConfigureServices((App.ConfigureServices));
            builder.ConfigureLogging(logging =>
            {
             
            });

            return builder;
        }
    }
}
