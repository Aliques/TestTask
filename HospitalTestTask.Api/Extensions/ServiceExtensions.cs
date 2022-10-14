using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Interfaces.Services;
using HospitalTestTask.Infrastructure;
using HospitalTestTask.Infrastructure.Profiles;
using HospitalTestTask.Infrastructure.Repositories;
using HospitalTestTask.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HospitalTestTask.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
             b => b.MigrationsAssembly("HospitalTestTask.Infrastructure")));
        }

        public static void ServicesCofiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(DoctorProfiles)));
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IDoctorService, DoctorService>();
        }
    }
}
