using Ginkoya.MaintenanceManager.Data;
using Ginkoya.MaintenanceManager.Services.Interfaces;

namespace Ginkoya.MaintenanceManager.Server.Extensions
{
    public static class ServicesExtensionMethods
    {
        /// <summary>
        /// Manage injection dependency into the IOC 
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void AddInjectionDependencies(this IServiceCollection serviceProvider)
        {
            // Inject data context factory
            serviceProvider.AddTransient(typeof(IDBContextFactory), typeof(MainDbContextFactory));

            // Inject services
            var baseServiceInterface = typeof(IService);
            var serviceTypes = baseServiceInterface.Assembly
                                                   .GetTypes()
                                                   .Where(p => baseServiceInterface.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);

            foreach (var service in serviceTypes)
            {
                var serviceInterface = service.GetInterfaces().FirstOrDefault(i => i.FullName.Contains(service.Name));
                if (service != null && serviceInterface != null)
                {
                    serviceProvider.AddTransient(serviceInterface, service);
                }
                else if (service != null)
                {
                    serviceProvider.AddTransient(service);
                }
            }

        }
    }
}
