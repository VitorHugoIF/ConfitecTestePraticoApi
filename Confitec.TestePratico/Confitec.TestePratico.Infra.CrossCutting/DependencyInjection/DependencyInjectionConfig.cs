using Confitec.TestePratico.Domain.Interfaces.Repository;
using Confitec.TestePratico.Domain.Interfaces.Service;
using Confitec.TestePratico.Domain.Services;
using Confitec.TestePratico.Infra.Data.Repositories;
using Confitec.TestePratico.Service.Interfaces;
using Confitec.TestePratico.Service.Mapping.User;
using Confitec.TestePratico.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Confitec.TestePratico.Infra.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static void AddRepositoryDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void AddServiceDependencyInjectionConfiguration(this IServiceCollection services)
        {
            //Domain
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IUserService, UserService>();
            //Application
            services.AddScoped<IUserAppService, UserAppService>();
        }

        public static void AddAutomapperDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper
            (
                typeof(UserProfile)
            );
        }
    }
}
