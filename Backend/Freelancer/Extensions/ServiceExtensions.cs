using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Freelancer.Extensions
{
    public static class ServiceExtensions
    {
        private static readonly string OpenApiInfoTitle = "Freelancer";
        private static readonly string OpenApiInfoVersion = "v1";

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = OpenApiInfoTitle, Version = OpenApiInfoVersion }));
        }
    }
}
