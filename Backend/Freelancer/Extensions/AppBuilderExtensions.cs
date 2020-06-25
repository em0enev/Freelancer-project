using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Extensions
{
    public static class AppBuilderExtensions
    {
        private static readonly string SwaggerEndpointURL = "/swagger/v1/swagger.json";
        private static readonly string SwaggerEndpointName = "Freelancer-v1";
        public static void AddSwager(this IApplicationBuilder appBuilder)
        {
            appBuilder.UseSwagger();

            appBuilder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: SwaggerEndpointURL, name: SwaggerEndpointName);
            });
        }
    }
}
