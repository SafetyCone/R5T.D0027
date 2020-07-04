using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0027.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="MachineNameProvider"/> implementation of <see cref="IMachineNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddMachineNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IMachineNameProvider, MachineNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="MachineNameProvider"/> implementation of <see cref="IMachineNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMachineNameProvider> AddMachineNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IMachineNameProvider>(() => services.AddMachineNameProvider());
            return serviceAction;
        }
    }
}
