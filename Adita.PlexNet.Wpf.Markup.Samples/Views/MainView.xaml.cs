using Adita.PlexNet.Wpf.Markup.Samples.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Windows.Controls;

namespace Adita.PlexNet.Wpf.Markup.Samples.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = App.Current.ServiceProvider.GetRequiredService<MainViewModel>();
            }
        }
    }
}
