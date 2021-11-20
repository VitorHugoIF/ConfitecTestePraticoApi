using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Confitec.TestePratico.Service.Validations.User;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Confitec.TestePratico.App.Extensions
{
    public static class FluentValidationExtension
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(x =>
                {
                    x.RegisterValidatorsFromAssemblyContaining<UserValidator>();
                    x.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                });
        }
    }
}
