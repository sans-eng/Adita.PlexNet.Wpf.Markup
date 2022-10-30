using Adita.PlexNet.Wpf.Markup.Samples.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adita.PlexNet.Wpf.Markup.Samples.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private string _data = string.Empty;

        public MainViewModel(DataService dataService)
        {
            _data = dataService.Data1;
        }

    }
}
