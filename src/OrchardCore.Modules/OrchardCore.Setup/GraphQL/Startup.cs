using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Apis;
using OrchardCore.Apis.GraphQL;
using OrchardCore.Contents.GraphQL;
using OrchardCore.Modules;

namespace OrchardCore.Setup.GraphQL
{
    [RequireFeatures("OrchardCore.Apis.GraphQL")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphMutationType<CreateTenantMutation>();
            services.AddScoped<CreateTenantOutcomeType>();
            services.AddSingleton<IGraphQLSchemaHashService, GraphQLSchemaHashService>();
        }
    }
}