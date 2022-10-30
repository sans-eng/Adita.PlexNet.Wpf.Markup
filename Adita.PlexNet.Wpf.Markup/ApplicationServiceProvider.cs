using Adita.PlexNet.Core.Hosting;
using System;
using System.Windows;

namespace Adita.PlexNet.Wpf.Markup
{
    internal static class ApplicationServiceProvider
    {
        #region Public methods
        internal static IServiceProvider? GetServiceProvider()
        {
            return Application.Current is IApplication application ? application.ServiceProvider : null;
        }
        #endregion Public methods
    }
}
