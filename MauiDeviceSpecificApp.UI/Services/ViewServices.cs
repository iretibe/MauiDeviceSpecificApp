namespace MauiDeviceSpecificApp.UI.Services
{
    public static class ViewServices
    {
        private static IServiceCollection _services;

        public static MauiAppBuilder UseViewService(this MauiAppBuilder builder)
        {
            _services = builder.Services;

            return builder;
        }

        public static ContentPage ResolvePage<TService>(params object[] inputParameters)
        {
            var implementationType = _services
                .Where(services => services.ServiceType == typeof(TService) && services.ImplementationType != null)
                .Select(services => services.ImplementationType)
                .First();

            return (Activator.CreateInstance(implementationType, inputParameters)) as ContentPage;
        }
    }
}
