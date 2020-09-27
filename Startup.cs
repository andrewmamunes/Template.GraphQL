using DiscGolf.GraphQL.Data.Models;
using DiscGolf.GraphQL.Data.Modules;
using DiscGolf.GraphQL.Types.Query;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DiscGolf.GraphQL
{
    public class Startup
    {

        public static IConfiguration Configuration { get; set; }
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc();

            var connectionString = Configuration.GetConnectionString("GolfDb");

            services.AddDbContext<GolfContext>((options) =>
            {
                options.UseSqlServer(connectionString);
            });

            services
                .RegisterDataServices()
                .AddDataLoaderRegistry()
                .AddGraphQL(sp => SchemaBuilder.New()
                                .AddQueryType<QueryType>()
                                .AddServices(sp)
                                .Create(),
                                new QueryExecutionOptions { ForceSerialExecution = true});


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseGraphQL();
        }
    }
}
