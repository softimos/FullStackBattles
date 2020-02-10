using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Softimos.FullStackBattles.DAL.Repositories;
using Softimos.FullStackBattles.Database;
using Softimos.FullStackBattles.DTO;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace Softimos.FullStackBattles.WebApi
{
    /// <summary>
    /// Configures the application at start time.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The application configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the application configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Identifies The CORS policy by its unique name
        /// </summary>
        private string _corsPolicyName = "AllowAll";

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">The services collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    _corsPolicyName,
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services.AddControllers();

            services.AddTransient<IRepository<Person>, PersonRepository>();
            services.AddTransient<IRepository<Starship>, StarshipRepository>();

            services.AddDbContext<CustomDatabaseContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("default")));

            InitializeSwagger(services);
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        /// <param name="logger">The logger.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            try
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FullStack Battles API v1");
                });

                using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<CustomDatabaseContext>();
                    context.PrepareDatabase();
                }

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

                app.UseCors(_corsPolicyName);

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers().RequireCors(_corsPolicyName);
                });
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, "An error occurred while configuring Web API application.");
            }
        }

        /// <summary>
        /// Initializes Swagger configuration.
        /// </summary>
        /// <param name="services">The services collection.</param>
        private void InitializeSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "FullStack Battles API",
                    Description = "RESTful API created for Code&Pepper exercise.",
                    Contact = new OpenApiContact
                    {
                        Name = "Mariusz Ignatowicz",
                        Email = "mariusz.ignatowicz@gmail.com",
                        Url = new Uri("https://github.com/softimos/FullStackBattles"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Licensed under MIT",
                        Url = new Uri("https://github.com/softimos/FullStackBattles/blob/master/LICENSE"),
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
    }
}
