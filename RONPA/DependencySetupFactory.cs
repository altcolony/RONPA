using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RONPA
{
    public class DependencySetupFactory
    {
        public InMemoryDependencySetup CreateSetup(IConfiguration configuration)
        {
            var setupName = configuration["Dependency:SetupName"];
            switch (setupName)
            {
                case nameof(InMemoryDependencySetup):
                    return new InMemoryDependencySetup();
                default:
                    throw new Exception();
            }
        }
    }
}
