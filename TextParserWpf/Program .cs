using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace TextParserWpf
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();
            App app = host.Services.GetService<App>();
            app?.Run();
        }
    }
}
