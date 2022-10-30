using Adita.PlexNet.Wpf.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Adita.PlexNet.Wpf.Markup.Samples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, IWpfApplication
    {
        public static new App Current => (App)Application.Current;
        public IServiceProvider ServiceProvider { get; private set; } = default!;

        public IConfiguration Configuration { get; private set; } = default!;

        public void SetConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
