﻿using Persistence;
using Persistence.RepositoryContract;
using Persistence.RepositoryImplementation;
using Service.Contract;
using Service.Implementation;

namespace DigiDocumentation.Extenstions
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

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();

        //public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddSingleton<MongoDbConnection>();
        //}

    }
}
