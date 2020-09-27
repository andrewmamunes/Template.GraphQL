using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DiscGolf.GraphQL.Data.Modules
{
    public static class DataModule
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services) 
        {
            return services
                .AddTransient<CourseRepository>()
                .AddTransient<RoundRepository>()
                .AddTransient<HoleRepository>()
                .AddTransient<HoleResultRepository>()
                .AddTransient<PersonRepository>();
        }
    }
}
