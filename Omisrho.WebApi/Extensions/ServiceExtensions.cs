using LoggerServices;
using Microsoft.EntityFrameworkCore;
using Omisrho.Application.Contracts;
using Omisrho.Infrastrucutre.EntityFrameworkCore;

namespace Omisrho.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .WithMethods("POST", "GET", "PUT")
                .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                //options.AuthenticationDisplayName = null;
            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        ////public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        ////services.AddDbContext<RepositoryContext>(opts =>
        ////    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
