using Luval.HealthMate.Fitbit.Resolver;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit
{
    public static class Extensions
    {
        public static IServiceCollection AddFitbit(this IServiceCollection services)
        {
            services.AddScoped<FitbitTokenResolver>();
            services.AddScoped<FitbitClient>();
            return services;
        }
    }
}
