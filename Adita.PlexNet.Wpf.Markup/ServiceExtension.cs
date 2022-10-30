using System;
using System.Windows.Markup;

namespace Adita.PlexNet.Wpf.Markup
{
    /// <summary>
    /// Represents a service extension that resolve a service object from current application.
    /// </summary>
    /// <remarks>
    /// To use this extensions the application need to implements the PlexNet framework WPF hosting, otherwise will be always return <see langword="null"/>
    /// when try to resolving the value.
    /// </remarks>
    [MarkupExtensionReturnType(typeof(Type))]
    public class ServiceExtension : MarkupExtension
    {
        #region Constructors
        /// <summary>
        /// Initialize a new instance of <see cref="ServiceExtension"/> using specified <paramref name="serviceType"/>.
        /// </summary>
        /// <param name="serviceType">A <see cref="Type"/> of a service to resolve.</param>
        /// <exception cref="ArgumentNullException"><paramref name="serviceType"/> is <c>null</c>.</exception>
        public ServiceExtension(Type serviceType)
        {
            ServiceType = serviceType ?? throw new ArgumentNullException(nameof(serviceType));
        }
        #endregion Constructors

        #region Public properties
        /// <summary>
        /// Gets or sets the service <see cref="Type"/> to resolve.
        /// </summary>
        public Type ServiceType { get; set; }
        #endregion Public properties

        #region Public methods
        /// <summary>Returns a service object that is provided as the value of the target property for this <see cref="ServiceExtension"/>.</summary>
        /// <param name="serviceProvider">A service provider helper that can provide services for the <see cref="ServiceExtension"/>.</param>
        /// <returns>The service object value to set on the property where the <see cref="ServiceExtension"/> is applied,
        /// or <see langword="null"/> if the service of specified <see cref="ServiceType"/> is not found.</returns>
        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            IServiceProvider? provider = ApplicationServiceProvider.GetServiceProvider();

            return provider?.GetService(ServiceType);
        }
        #endregion Public methods
    }
}
