using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PortalApi.Contexts;
using PortalApi.Services;
using PortalApi.Validators;
using PortalApi.Helpers;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Hangfire;

namespace PortalApi
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // use sql server db in production and sqlite db in development
            //if (_env.IsProduction())
            //    services.AddDbContext<DataContext>();
            //else
            //    services.AddDbContext<DataContext, SqliteDataContext>();


            // configure strongly typed settings objects
            var appSettingsSection = _configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                        var userId = int.Parse(context.Principal.Identity.Name);
                        var user = userService.GetById(userId);
                        if (user == null)
                        {
                            // return unauthorized if user no longer exists
                            context.Fail("Unauthorized");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddAuthorization();
            services.AddCors();
            //services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var sqlProvider = _configuration.GetValue<string>("AppSettings:SqlProvider");
            Console.WriteLine($"appsettings.SqlProvider: {sqlProvider}");
            services.AddDbContext<PortalContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString($"DBConnectionString_{sqlProvider}"));
            });
            Console.WriteLine($" 'DBConnectionString_{sqlProvider}' database is used");
            services.AddScoped<IPortalRepository, PortalRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddTransient<IResourceValidator, ResourceValidator>();
            services.AddTransient<IMailService, MailService>();

            services.AddHangfire(x => x.UseSqlServerStorage(_configuration.GetConnectionString($"DBConnectionString_{sqlProvider}")));
            services.AddHangfireServer();

            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc(
                    "PortalRzeszowAPISpecification",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Portal Rzeszow API",
                        Version = "1.0.0.0"
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // migrate any database changes on startup (includes initial db creation)
            //dataContext.Database.Migrate();
            loggerFactory.AddFile("Logs/log_portal.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder =>
                builder
                .WithOrigins("http://localhost:8080", "https://clever-sinoussi-66dbb8.netlify.app")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
            );

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/PortalRzeszowAPISpecification/swagger.json", "Poratl Rzeszow API 1");
                c.RoutePrefix = "";
            });

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                DashboardTitle = "Sample Jobs",
                Authorization = new[]
    {
                new  HangfireAuthorizationFilter("admin")
            }
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
