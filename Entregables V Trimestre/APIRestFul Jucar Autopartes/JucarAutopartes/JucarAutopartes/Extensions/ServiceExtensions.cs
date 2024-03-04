﻿using Contracts;
using LoggerService;
using Repository;
using Service.Contracts;
using Service;
using Microsoft.EntityFrameworkCore;
using JucarAutopartes;
using Entities.Models.Users;
using Microsoft.AspNetCore.Identity;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Entities.ConfigurationModels;
using Microsoft.OpenApi.Models;

namespace JucarAutopartes.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("SqlConnection")));

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));

        /* Configuración de Identity */

        public static void ConfigureIdentity(this IServiceCollection services) 
        { 
            var builder = services.AddIdentity<User, IdentityRole>(o => 
            { 
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true; 
            })
            .AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders(); 
        }

        /* Rate Limiting*/

        public static void ConfigureRateLimitingOptions(this IServiceCollection services) 
        {
            var rateLimitRules = new List<RateLimitRule> 
            { 
                new RateLimitRule 
                { 
                    Endpoint = "*", 
                    Limit = 100, 
                    Period = "5m" 
                } 
            }; 
            
            services.Configure<IpRateLimitOptions>(opt => { opt.GeneralRules = rateLimitRules; }); 
            
            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>(); 
            
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>(); 
            
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>(); 
            
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>(); 
        }

        /* Configuración de JWT */

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration) 
        {
            var jwtConfiguration = new JwtConfiguration(); 
            
            configuration.Bind(jwtConfiguration.Section, jwtConfiguration);

            var secretKey = Environment.GetEnvironmentVariable("SECRETII");

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = jwtConfiguration.ValidIssuer,
                    ValidAudience = jwtConfiguration.ValidAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }

        public static void AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration) => 
            services.Configure<JwtConfiguration>(configuration.GetSection("JwtSettings"));

        /* Swagger */

        public static void ConfigureSwagger(this IServiceCollection services) 
        {
            services.AddSwaggerGen(s => 
            { 
                s.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Jucar Autopartes API",
                    Version = "v1",
                    Description = "Jucar Autopartes API by Miguel Palacio",
                    Contact = new OpenApiContact 
                    { 
                        Name = "Miguel Palacio",
                        Email = "miguelpokerafce@gmail.com",
                    }
                });

                //s.SwaggerDoc("v2", new OpenApiInfo { Title = "Jucar Autopartes API", Version = "v2" });

                var xmlFile = $"{typeof(Presentation.AssemblyReference).Assembly.GetName().Name}.xml";

                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                s.IncludeXmlComments(xmlPath);

                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement() 
                { 
                    { 
                        new OpenApiSecurityScheme
                        { 
                            Reference = new OpenApiReference 
                            { 
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }, 
                            Name = "Bearer",
                        },
                        new List<string>() 
                    } 
                });
            });
        }
    }
}
