using Adita.PlexNet.Core.Hosting;
using Adita.PlexNet.Wpf.Hosting;
using Adita.PlexNet.Wpf.Markup.Samples.Services;
using Adita.PlexNet.Wpf.Markup.Samples.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adita.PlexNet.Wpf.Markup.Samples
{
    public static class Startup
    {
        [STAThread]
        public static void Main()
        {
            IApplicationBuilder<App> builder = new ApplicationBuilder<App>();

            builder.ConfigureServices(configure =>
            {
                configure.AddScoped<MainViewModel>()
                .AddScoped<DataService>();
            });

            App app = builder.Build();

            app.InitializeComponent();
            app.Run();
        }
    }
}
