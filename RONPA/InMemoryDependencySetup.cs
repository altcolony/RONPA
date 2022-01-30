using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RONPA.Application;
using RONPA.InMemory;
using RONPA.Domain;

namespace RONPA
{
    public class InMemoryDependencySetup
    {
        public void Run(IServiceCollection services)
        {
            SetupRepository(services);
            SetupApplication(services);
        }
        private void SetupRepository(IServiceCollection services)
        {
            services.AddSingleton<IKnowledgeRepository, InMemoryCardRepository>();
            services.AddSingleton<IClaimRepository, InMemoryClaimRepository>();

        }
        private void SetupApplication(IServiceCollection services)
        {
            services.AddTransient<CardApplication>();
            services.AddTransient<ClaimApplication>();
        }
    }
}
