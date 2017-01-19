using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;

namespace CommerceService
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// The FabricRuntime creates an instance of this class for each service type instance. 
    /// </summary>
    internal sealed class CommerceService : StatelessService
    {
        private static StatelessServiceContext Context;

        internal static string GetConfigurationValue(string key)
        {
            var configurationPackage = Context.CodePackageActivationContext.GetConfigurationPackageObject("Config");
            return configurationPackage.Settings.Sections["ApplicationSettings"].Parameters[key].Value;
        }

        public CommerceService(StatelessServiceContext context)
        : base(context)
        {
            CommerceService.Context = context;
        }

        /// <summary>
        /// Optional override to create listeners (like tcp, http) for this service instance.
        /// </summary>
        /// <returns>The collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new ServiceInstanceListener[]
            {
                new ServiceInstanceListener(serviceContext => new OwinCommunicationListener(Startup.ConfigureApp, serviceContext, ServiceEventSource.Current, "ServiceEndpoint"))
            };
        }
    }
}
